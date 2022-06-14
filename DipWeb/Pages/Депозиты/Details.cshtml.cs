using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using DipWeb.Data;
using DipWeb.Model;

namespace DipWeb.Pages.Депозиты
{
    public class DetailsModel : PageModel
    {
        private readonly DipWeb.Data.ApplicationDbContext _context;

        public DetailsModel(DipWeb.Data.ApplicationDbContext context)
        {
            _context = context;
        }

      public DipWeb.Model.Депозиты Депозиты { get; set; } = default!; 

        public async Task<IActionResult> OnGetAsync(Guid? id)
        {
            if (id == null || _context.Депозиты == null)
            {
                return NotFound();
            }

            var депозиты = await _context.Депозиты.FirstOrDefaultAsync(m => m.ИдентификаторДепозита == id);
            if (депозиты == null)
            {
                return NotFound();
            }
            else 
            {
                Депозиты = депозиты;
            }
            return Page();
        }
    }
}
