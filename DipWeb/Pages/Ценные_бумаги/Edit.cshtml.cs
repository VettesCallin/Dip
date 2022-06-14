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

namespace DipWeb.Pages.Ценные_бумаги
{
    public class EditModel : PageModel
    {
        private readonly DipWeb.Data.ApplicationDbContext _context;

        public EditModel(DipWeb.Data.ApplicationDbContext context)
        {
            _context = context;
        }

        [BindProperty]
        public ЦенныеБумаги ЦенныеБумаги { get; set; } = default!;

        public async Task<IActionResult> OnGetAsync(Guid? id)
        {
            if (id == null || _context.ЦенныеБумаги == null)
            {
                return NotFound();
            }

            var ценныебумаги =  await _context.ЦенныеБумаги.FirstOrDefaultAsync(m => m.ИдентификаторЦеннойБумаги == id);
            if (ценныебумаги == null)
            {
                return NotFound();
            }
            ЦенныеБумаги = ценныебумаги;
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

            _context.Attach(ЦенныеБумаги).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!ЦенныеБумагиExists(ЦенныеБумаги.ИдентификаторЦеннойБумаги))
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

        private bool ЦенныеБумагиExists(Guid id)
        {
          return (_context.ЦенныеБумаги?.Any(e => e.ИдентификаторЦеннойБумаги == id)).GetValueOrDefault();
        }
    }
}
