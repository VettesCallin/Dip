using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using DipWeb.Data;
using DipWeb.Model;

namespace DipWeb.Pages.Переводы
{
    public class DeleteModel : PageModel
    {
        private readonly DipWeb.Data.ApplicationDbContext _context;

        public DeleteModel(DipWeb.Data.ApplicationDbContext context)
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

            var переводы = await _context.Переводы.FirstOrDefaultAsync(m => m.ИдентификаторПеревода == id);

            if (переводы == null)
            {
                return NotFound();
            }
            else 
            {
                Переводы = переводы;
            }
            return Page();
        }

        public async Task<IActionResult> OnPostAsync(Guid? id)
        {
            if (id == null || _context.Переводы == null)
            {
                return NotFound();
            }
            var переводы = await _context.Переводы.FindAsync(id);

            if (переводы != null)
            {
                Переводы = переводы;
                _context.Переводы.Remove(Переводы);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }
    }
}
