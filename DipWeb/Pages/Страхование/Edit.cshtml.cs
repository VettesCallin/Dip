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

namespace DipWeb.Pages.Страхование
{
    public class EditModel : PageModel
    {
        private readonly DipWeb.Data.ApplicationDbContext _context;

        public EditModel(DipWeb.Data.ApplicationDbContext context)
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

            var страхование =  await _context.Страхование.FirstOrDefaultAsync(m => m.ИдентификаторСтрахования == id);
            if (страхование == null)
            {
                return NotFound();
            }
            Страхование = страхование;
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

            _context.Attach(Страхование).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!СтрахованиеExists(Страхование.ИдентификаторСтрахования))
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

        private bool СтрахованиеExists(Guid id)
        {
          return (_context.Страхование?.Any(e => e.ИдентификаторСтрахования == id)).GetValueOrDefault();
        }
    }
}
