using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using DipWeb.Data;
using DipWeb.Model;

namespace DipWeb.Pages.Адреса
{
    public class EditModel : PageModel
    {
        private readonly DipWeb.Data.ApplicationDbContext _context;

        public EditModel(DipWeb.Data.ApplicationDbContext context)
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

            var адреса =  await _context.Адреса.FirstOrDefaultAsync(m => m.ИдентификаторАдреса == id);
            if (адреса == null)
            {
                return NotFound();
            }
            Адреса = адреса;
            return Page();
        }

        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Attach(Адреса).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!АдресаExists(Адреса.ИдентификаторАдреса))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return RedirectToPage("./Index");
        }

        private bool АдресаExists(Guid id)
        {
          return (_context.Адреса?.Any(e => e.ИдентификаторАдреса == id)).GetValueOrDefault();
        }
    }
}
