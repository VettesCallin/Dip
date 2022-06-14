using DipWeb.Data;
using DipWeb.Model;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace DipWeb.Pages.Валюты
{
    [BindProperties]
    public class DeleteModel : PageModel
    {
        private readonly ApplicationDbContext _db;
        public DipWeb.Model.Валюта Валюта { get; set; }
        public DeleteModel(ApplicationDbContext db)
        {
            _db= db;
        }
        public void OnGet(Guid id)
        {
            Валюта = _db.Валюты.Find(id);
            //Валюта = _db.Валюты.FirstOrDefault(u => u.ИдентификаторКодаВалюты == id);
            //Валюта = _db.Валюты.SingleOrDefault(u => u.ИдентификаторКодаВалюты == id);
            //Валюта = _db.Валюты.Where(u => u.ИдентификаторКодаВалюты == id).FirstOrDefault();
        }
        public async Task<IActionResult> OnPost()
        {

            var валютаБД = _db.Валюты.Find(Валюта.ИдентификаторКодаВалюты);
            if (валютаБД != null)
            {
                _db.Валюты.Remove(валютаБД);
                await _db.SaveChangesAsync();
                TempData["success"] = "Запись успешно удалена";
                return RedirectToPage("Index");
            }
            return Page();
        }
    }
}
