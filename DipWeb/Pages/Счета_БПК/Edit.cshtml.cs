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

namespace DipWeb.Pages.Счета_БПК
{
    public class EditModel : PageModel
    {
        private readonly DipWeb.Data.ApplicationDbContext _context;

        public EditModel(DipWeb.Data.ApplicationDbContext context)
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

            var счетабпк =  await _context.СчетаБПК.FirstOrDefaultAsync(m => m.ИдентификаторСчетаБПК == id);
            if (счетабпк == null)
            {
                return NotFound();
            }
            СчетаБПК = счетабпк;
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

            _context.Attach(СчетаБПК).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!СчетаБПКExists(СчетаБПК.ИдентификаторСчетаБПК))
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

        private bool СчетаБПКExists(Guid id)
        {
          return (_context.СчетаБПК?.Any(e => e.ИдентификаторСчетаБПК == id)).GetValueOrDefault();
        }
    }
}
