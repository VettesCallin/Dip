using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using DipWeb.Data;
using DipWeb.Model;

namespace DipWeb.Pages.Адреса
{
    public class DeleteModel : PageModel
    {
        private readonly DipWeb.Data.ApplicationDbContext _context;

        public DeleteModel(DipWeb.Data.ApplicationDbContext context)
        {
            _context = context;
        }

        [BindProperty]
      public DipWeb.Model.Адреса Адреса { get; set; } = default!;

        public async Task<IActionResult> OnGetAsync(Guid? id)
        {
            if (id == null || _context.Адреса == null)
            {
                return NotFound();
            }

            var адреса = await _context.Адреса.FirstOrDefaultAsync(m => m.ИдентификаторАдреса == id);

            if (адреса == null)
            {
                return NotFound();
            }
            else 
            {
                Адреса = адреса;
            }
            return Page();
        }

        public async Task<IActionResult> OnPostAsync(Guid? id)
        {
            if (id == null || _context.Адреса == null)
            {
                return NotFound();
            }
            var адреса = await _context.Адреса.FindAsync(id);

            if (адреса != null)
            {
                Адреса = адреса;
                _context.Адреса.Remove(Адреса);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }
    }
}
