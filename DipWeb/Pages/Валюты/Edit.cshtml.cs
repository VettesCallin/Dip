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

namespace DipWeb.Pages.Валюты
{
    public class EditModel : PageModel
    {
        private readonly DipWeb.Data.ApplicationDbContext _context;

        public EditModel(DipWeb.Data.ApplicationDbContext context)
        {
            _context = context;
        }

        [BindProperty]
        public Валюта Валюта { get; set; } = default!;

        public async Task<IActionResult> OnGetAsync(Guid? id)
        {
            if (id == null || _context.Валюта == null)
            {
                return NotFound();
            }

            var валюта =  await _context.Валюта.FirstOrDefaultAsync(m => m.ИдентификаторКодаВалюты == id);
            if (валюта == null)
            {
                return NotFound();
            }
            Валюта = валюта;
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

            _context.Attach(Валюта).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!ВалютаExists(Валюта.ИдентификаторКодаВалюты))
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

        private bool ВалютаExists(Guid id)
        {
          return (_context.Валюта?.Any(e => e.ИдентификаторКодаВалюты == id)).GetValueOrDefault();
        }
    }
}
