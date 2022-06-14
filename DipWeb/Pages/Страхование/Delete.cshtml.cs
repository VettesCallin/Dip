using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using DipWeb.Data;
using DipWeb.Model;

namespace DipWeb.Pages.Страхование
{
    public class DeleteModel : PageModel
    {
        private readonly DipWeb.Data.ApplicationDbContext _context;

        public DeleteModel(DipWeb.Data.ApplicationDbContext context)
        {
            _context = context;
        }

        [BindProperty]
      public DipWeb.Model.Страхование Страхование { get; set; } = default!;

        public async Task<IActionResult> OnGetAsync(Guid? id)
        {
            if (id == null || _context.Страхование == null)
            {
                return NotFound();
            }

            var страхование = await _context.Страхование.FirstOrDefaultAsync(m => m.ИдентификаторСтрахования == id);

            if (страхование == null)
            {
                return NotFound();
            }
            else 
            {
                Страхование = страхование;
            }
            return Page();
        }

        public async Task<IActionResult> OnPostAsync(Guid? id)
        {
            if (id == null || _context.Страхование == null)
            {
                return NotFound();
            }
            var страхование = await _context.Страхование.FindAsync(id);

            if (страхование != null)
            {
                Страхование = страхование;
                _context.Страхование.Remove(Страхование);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }
    }
}
