using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using DipWeb.Data;
using DipWeb.Model;

namespace DipWeb.Pages.Счета_БПК
{
    public class DeleteModel : PageModel
    {
        private readonly DipWeb.Data.ApplicationDbContext _context;

        public DeleteModel(DipWeb.Data.ApplicationDbContext context)
        {
            _context = context;
        }

        [BindProperty]
      public СчетаБПК СчетаБПК { get; set; } = default!;

        public async Task<IActionResult> OnGetAsync(Guid? id)
        {
            if (id == null || _context.СчетаБПК == null)
            {
                return NotFound();
            }

            var счетабпк = await _context.СчетаБПК.FirstOrDefaultAsync(m => m.ИдентификаторСчетаБПК == id);

            if (счетабпк == null)
            {
                return NotFound();
            }
            else 
            {
                СчетаБПК = счетабпк;
            }
            return Page();
        }

        public async Task<IActionResult> OnPostAsync(Guid? id)
        {
            if (id == null || _context.СчетаБПК == null)
            {
                return NotFound();
            }
            var счетабпк = await _context.СчетаБПК.FindAsync(id);

            if (счетабпк != null)
            {
                СчетаБПК = счетабпк;
                _context.СчетаБПК.Remove(СчетаБПК);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }
    }
}
