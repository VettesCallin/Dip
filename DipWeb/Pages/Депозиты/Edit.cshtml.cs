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

namespace DipWeb.Pages.Депозиты
{
    public class EditModel : PageModel
    {
        private readonly DipWeb.Data.ApplicationDbContext _context;

        public EditModel(DipWeb.Data.ApplicationDbContext context)
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

            var депозиты =  await _context.Депозиты.FirstOrDefaultAsync(m => m.ИдентификаторДепозита == id);
            if (депозиты == null)
            {
                return NotFound();
            }
            Депозиты = депозиты;
            return Page();
        }

        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see https://aka.ms/RazorPagesCRUD.
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Attach(Депозиты).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!ДепозитыExists(Депозиты.ИдентификаторДепозита))
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

        private bool ДепозитыExists(Guid id)
        {
          return (_context.Депозиты?.Any(e => e.ИдентификаторДепозита == id)).GetValueOrDefault();
        }
    }
}
