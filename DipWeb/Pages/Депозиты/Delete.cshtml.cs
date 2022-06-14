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
    public class DeleteModel : PageModel
    {
        private readonly DipWeb.Data.ApplicationDbContext _context;

        public DeleteModel(DipWeb.Data.ApplicationDbContext context)
        {
            _context = context;
        }

        [BindProperty]
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

        public async Task<IActionResult> OnPostAsync(Guid? id)
        {
            if (id == null || _context.Депозиты == null)
            {
                return NotFound();
            }
            var депозиты = await _context.Депозиты.FindAsync(id);

            if (депозиты != null)
            {
                Депозиты = депозиты;
                _context.Депозиты.Remove(Депозиты);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }
    }
}
