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

namespace DipWeb.Pages.Текущие_счета
{
    public class EditModel : PageModel
    {
        private readonly DipWeb.Data.ApplicationDbContext _context;

        public EditModel(DipWeb.Data.ApplicationDbContext context)
        {
            _context = context;
        }

        [BindProperty]
        public ТекущиеСчета ТекущиеСчета { get; set; } = default!;

        public async Task<IActionResult> OnGetAsync(Guid? id)
        {
            if (id == null || _context.ТекущиеСчета == null)
            {
                return NotFound();
            }

            var текущиесчета =  await _context.ТекущиеСчета.FirstOrDefaultAsync(m => m.ИдентификаторТекущегоСчета == id);
            if (текущиесчета == null)
            {
                return NotFound();
            }
            ТекущиеСчета = текущиесчета;
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

            _context.Attach(ТекущиеСчета).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!ТекущиеСчетаExists(ТекущиеСчета.ИдентификаторТекущегоСчета))
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

        private bool ТекущиеСчетаExists(Guid id)
        {
          return (_context.ТекущиеСчета?.Any(e => e.ИдентификаторТекущегоСчета == id)).GetValueOrDefault();
        }
    }
}
