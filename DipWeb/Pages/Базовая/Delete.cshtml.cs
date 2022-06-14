using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using DipWeb.Data;
using DipWeb.Model;

namespace DipWeb.Pages.Базовая_величина
{
    public class DeleteModel : PageModel
    {
        private readonly DipWeb.Data.ApplicationDbContext _context;

        public DeleteModel(DipWeb.Data.ApplicationDbContext context)
        {
            _context = context;
        }

        [BindProperty]
      public БазоваяВеличина БазоваяВеличина { get; set; } = default!;

        public async Task<IActionResult> OnGetAsync(Guid? id)
        {
            if (id == null || _context.БазоваяВеличина == null)
            {
                return NotFound();
            }

            var базоваявеличина = await _context.БазоваяВеличина.FirstOrDefaultAsync(m => m.ИдентификаторБазовойВеличины == id);

            if (базоваявеличина == null)
            {
                return NotFound();
            }
            else 
            {
                БазоваяВеличина = базоваявеличина;
            }
            return Page();
        }

        public async Task<IActionResult> OnPostAsync(Guid? id)
        {
            if (id == null || _context.БазоваяВеличина == null)
            {
                return NotFound();
            }
            var базоваявеличина = await _context.БазоваяВеличина.FindAsync(id);

            if (базоваявеличина != null)
            {
                БазоваяВеличина = базоваявеличина;
                _context.БазоваяВеличина.Remove(БазоваяВеличина);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }
    }
}
