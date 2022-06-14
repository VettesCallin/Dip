using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using DipWeb.Data;
using DipWeb.Model;

namespace DipWeb.Pages.Валюты
{
    public class DeleteModel : PageModel
    {
        private readonly DipWeb.Data.ApplicationDbContext _context;

        public DeleteModel(DipWeb.Data.ApplicationDbContext context)
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

            var валюта = await _context.Валюта.FirstOrDefaultAsync(m => m.ИдентификаторКодаВалюты == id);

            if (валюта == null)
            {
                return NotFound();
            }
            else 
            {
                Валюта = валюта;
            }
            return Page();
        }

        public async Task<IActionResult> OnPostAsync(Guid? id)
        {
            if (id == null || _context.Валюта == null)
            {
                return NotFound();
            }
            var валюта = await _context.Валюта.FindAsync(id);

            if (валюта != null)
            {
                Валюта = валюта;
                _context.Валюта.Remove(Валюта);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }
    }
}
