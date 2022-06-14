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

namespace DipWeb.Pages.Платежи_3м_лицам
{
    public class EditModel : PageModel
    {
        private readonly DipWeb.Data.ApplicationDbContext _context;

        public EditModel(DipWeb.Data.ApplicationDbContext context)
        {
            _context = context;
        }

        [BindProperty]
        public DipWeb.Model.Платежи_3м_лицам Платежи_3м_лицам { get; set; } = default!;

        public async Task<IActionResult> OnGetAsync(Guid? id)
        {
            if (id == null || _context.Платежи_3м_лицам == null)
            {
                return NotFound();
            }

            var платежи_3м_лицам =  await _context.Платежи_3м_лицам.FirstOrDefaultAsync(m => m.ИдентификаторПлатежа3мЛицам == id);
            if (платежи_3м_лицам == null)
            {
                return NotFound();
            }
            Платежи_3м_лицам = платежи_3м_лицам;
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

            _context.Attach(Платежи_3м_лицам).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!Платежи_3м_лицамExists(Платежи_3м_лицам.ИдентификаторПлатежа3мЛицам))
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

        private bool Платежи_3м_лицамExists(Guid id)
        {
          return (_context.Платежи_3м_лицам?.Any(e => e.ИдентификаторПлатежа3мЛицам == id)).GetValueOrDefault();
        }
    }
}
