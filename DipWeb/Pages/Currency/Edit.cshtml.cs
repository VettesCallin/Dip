using DipWeb.Data;
using DipWeb.Model;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace DipWeb.Pages.Валюты
{
    [BindProperties]
    public class EditModel : PageModel
    {
        private readonly ApplicationDbContext _db;
        public DipWeb.Model.Валюта Валюта { get; set; }
        public EditModel(ApplicationDbContext db)
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
            if (ModelState.IsValid)
            {
                _db.Валюты.Update(Валюта);
                await _db.SaveChangesAsync();
                TempData["success"] = "Запись успешно изменена";
                return RedirectToPage("Index");
            }
            return Page();
        }
    }
}
