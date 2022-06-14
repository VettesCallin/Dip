using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using DipWeb.Data;
using DipWeb.Model;

namespace DipWeb.Pages.БПК
{
    public class DeleteModel : PageModel
    {
        private readonly DipWeb.Data.ApplicationDbContext _context;

        public DeleteModel(DipWeb.Data.ApplicationDbContext context)
        {
            _context = context;
        }

        [BindProperty]
      public DipWeb.Model.БПК БПК { get; set; } = default!;

        public async Task<IActionResult> OnGetAsync(Guid? id)
        {
            if (id == null || _context.БПК == null)
            {
                return NotFound();
            }

            var бпк = await _context.БПК.FirstOrDefaultAsync(m => m.ИдентификаторБПК == id);

            if (бпк == null)
            {
                return NotFound();
            }
            else 
            {
                БПК = бпк;
            }
            return Page();
        }

        public async Task<IActionResult> OnPostAsync(Guid? id)
        {
            if (id == null || _context.БПК == null)
            {
                return NotFound();
            }
            var бпк = await _context.БПК.FindAsync(id);

            if (бпк != null)
            {
                БПК = бпк;
                _context.БПК.Remove(БПК);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }
    }
}
