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

namespace DipWeb.Pages.Переводы
{
    public class EditModel : PageModel
    {
        private readonly DipWeb.Data.ApplicationDbContext _context;

        public EditModel(DipWeb.Data.ApplicationDbContext context)
        {
            _context = context;
        }

        [BindProperty]
        public DipWeb.Model.Переводы Переводы { get; set; } = default!;

        public async Task<IActionResult> OnGetAsync(Guid? id)
        {
            if (id == null || _context.Переводы == null)
            {
                return NotFound();
            }

            var переводы =  await _context.Переводы.FirstOrDefaultAsync(m => m.ИдентификаторПеревода == id);
            if (переводы == null)
            {
                return NotFound();
            }
            Переводы = переводы;
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

            _context.Attach(Переводы).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!ПереводыExists(Переводы.ИдентификаторПеревода))
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

        private bool ПереводыExists(Guid id)
        {
          return (_context.Переводы?.Any(e => e.ИдентификаторПеревода == id)).GetValueOrDefault();
        }
    }
}
