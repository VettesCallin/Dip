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

namespace DipWeb.Pages.Базовая_величина
{
    public class EditModel : PageModel
    {
        private readonly DipWeb.Data.ApplicationDbContext _context;

        public EditModel(DipWeb.Data.ApplicationDbContext context)
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

            var базоваявеличина =  await _context.БазоваяВеличина.FirstOrDefaultAsync(m => m.ИдентификаторБазовойВеличины == id);
            if (базоваявеличина == null)
            {
                return NotFound();
            }
            БазоваяВеличина = базоваявеличина;
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

            _context.Attach(БазоваяВеличина).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!БазоваяВеличинаExists(БазоваяВеличина.ИдентификаторБазовойВеличины))
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

        private bool БазоваяВеличинаExists(Guid id)
        {
          return (_context.БазоваяВеличина?.Any(e => e.ИдентификаторБазовойВеличины == id)).GetValueOrDefault();
        }
    }
}
