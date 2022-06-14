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

namespace DipWeb.Pages.Юридические_лица
{
    public class EditModel : PageModel
    {
        private readonly DipWeb.Data.ApplicationDbContext _context;

        public EditModel(DipWeb.Data.ApplicationDbContext context)
        {
            _context = context;
        }

        [BindProperty]
        public ЮридическиеЛица ЮридическиеЛица { get; set; } = default!;

        public async Task<IActionResult> OnGetAsync(Guid? id)
        {
            if (id == null || _context.ЮридическиеЛица == null)
            {
                return NotFound();
            }

            var юридическиелица =  await _context.ЮридическиеЛица.FirstOrDefaultAsync(m => m.ИдентификаторЮридическогоЛица == id);
            if (юридическиелица == null)
            {
                return NotFound();
            }
            ЮридическиеЛица = юридическиелица;
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

            _context.Attach(ЮридическиеЛица).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!ЮридическиеЛицаExists(ЮридическиеЛица.ИдентификаторЮридическогоЛица))
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

        private bool ЮридическиеЛицаExists(Guid id)
        {
          return (_context.ЮридическиеЛица?.Any(e => e.ИдентификаторЮридическогоЛица == id)).GetValueOrDefault();
        }
    }
}
