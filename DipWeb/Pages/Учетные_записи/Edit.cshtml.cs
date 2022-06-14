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

namespace DipWeb.Pages.Учетные_записи
{
    public class EditModel : PageModel
    {
        private readonly DipWeb.Data.ApplicationDbContext _context;

        public EditModel(DipWeb.Data.ApplicationDbContext context)
        {
            _context = context;
        }

        [BindProperty]
        public УчетныеЗаписи УчетныеЗаписи { get; set; } = default!;

        public async Task<IActionResult> OnGetAsync(Guid? id)
        {
            if (id == null || _context.УчетныеЗаписи == null)
            {
                return NotFound();
            }

            var учетныезаписи =  await _context.УчетныеЗаписи.FirstOrDefaultAsync(m => m.ИдентификаторУчетнойЗаписи == id);
            if (учетныезаписи == null)
            {
                return NotFound();
            }
            УчетныеЗаписи = учетныезаписи;
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

            _context.Attach(УчетныеЗаписи).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!УчетныеЗаписиExists(УчетныеЗаписи.ИдентификаторУчетнойЗаписи))
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

        private bool УчетныеЗаписиExists(Guid id)
        {
          return (_context.УчетныеЗаписи?.Any(e => e.ИдентификаторУчетнойЗаписи == id)).GetValueOrDefault();
        }
    }
}
