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

namespace DipWeb.Pages.Погашения_кредитов
{
    public class EditModel : PageModel
    {
        private readonly DipWeb.Data.ApplicationDbContext _context;

        public EditModel(DipWeb.Data.ApplicationDbContext context)
        {
            _context = context;
        }

        [BindProperty]
        public ПогашенияКредитов ПогашенияКредитов { get; set; } = default!;

        public async Task<IActionResult> OnGetAsync(Guid? id)
        {
            if (id == null || _context.ПогашенияКредитов == null)
            {
                return NotFound();
            }

            var погашениякредитов =  await _context.ПогашенияКредитов.FirstOrDefaultAsync(m => m.ИдентификаторПогашения == id);
            if (погашениякредитов == null)
            {
                return NotFound();
            }
            ПогашенияКредитов = погашениякредитов;
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

            _context.Attach(ПогашенияКредитов).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!ПогашенияКредитовExists(ПогашенияКредитов.ИдентификаторПогашения))
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

        private bool ПогашенияКредитовExists(Guid id)
        {
          return (_context.ПогашенияКредитов?.Any(e => e.ИдентификаторПогашения == id)).GetValueOrDefault();
        }
    }
}
