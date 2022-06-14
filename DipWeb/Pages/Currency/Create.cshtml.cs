using DipWeb.Data;
using DipWeb.Model;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace DipWeb.Pages.Валюты
{
    [BindProperties]
    public class CreateModel : PageModel
    {
        private readonly ApplicationDbContext _db;
        public DipWeb.Model.Валюта Валюта { get; set; }
        public CreateModel(ApplicationDbContext db)
        {
            _db= db;
        }
        public void OnGet()
        {
        }
        public async Task<IActionResult> OnPost()
        {
            if (ModelState.IsValid)
            {
                await _db.Валюты.AddAsync(Валюта);
                await _db.SaveChangesAsync();
                TempData["success"] = "Запись успешно добавлена";
                return RedirectToPage("Index");
            }
            return Page();
        }
    }
}
