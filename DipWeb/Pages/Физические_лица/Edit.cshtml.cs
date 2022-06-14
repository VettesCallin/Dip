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

namespace DipWeb.Pages.Физические_лица
{
    public class EditModel : PageModel
    {
        private readonly DipWeb.Data.ApplicationDbContext _context;

        public EditModel(DipWeb.Data.ApplicationDbContext context)
        {
            _context = context;
        }

        [BindProperty]
        public ФизическиеЛица ФизическиеЛица { get; set; } = default!;

        public async Task<IActionResult> OnGetAsync(Guid? id)
        {
            if (id == null || _context.ФизическиеЛица == null)
            {
                return NotFound();
            }

            var физическиелица =  await _context.ФизическиеЛица.FirstOrDefaultAsync(m => m.ИдентификаторФизическогоЛица == id);
            if (физическиелица == null)
            {
                return NotFound();
            }
            ФизическиеЛица = физическиелица;
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

            _context.Attach(ФизическиеЛица).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!ФизическиеЛицаExists(ФизическиеЛица.ИдентификаторФизическогоЛица))
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

        private bool ФизическиеЛицаExists(Guid id)
        {
          return (_context.ФизическиеЛица?.Any(e => e.ИдентификаторФизическогоЛица == id)).GetValueOrDefault();
        }
    }
}
