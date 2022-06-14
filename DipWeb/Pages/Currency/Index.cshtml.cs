using DipWeb.Data;
using DipWeb.Model;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace DipWeb.Pages.Валюты
{
    public class IndexModel : PageModel
    {
        private readonly ApplicationDbContext _db;
        public IEnumerable<DipWeb.Model.Валюта> Валюты { get; set; }
        public IndexModel(ApplicationDbContext db)
        {
            _db = db;
        }
        public void OnGet()
        {
            Валюты = (IEnumerable<DipWeb.Model.Валюта>)_db.Валюты; 
        }
    }
}
