using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using DipWeb.Data;
using DipWeb.Model;

namespace DipWeb.Pages.Погашения_кредитов
{
    public class DeleteModel : PageModel
    {
        private readonly DipWeb.Data.ApplicationDbContext _context;

        public DeleteModel(DipWeb.Data.ApplicationDbContext context)
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

            var погашениякредитов = await _context.ПогашенияКредитов.FirstOrDefaultAsync(m => m.ИдентификаторПогашения == id);

            if (погашениякредитов == null)
            {
                return NotFound();
            }
            else 
            {
                ПогашенияКредитов = погашениякредитов;
            }
            return Page();
        }

        public async Task<IActionResult> OnPostAsync(Guid? id)
        {
            if (id == null || _context.ПогашенияКредитов == null)
            {
                return NotFound();
            }
            var погашениякредитов = await _context.ПогашенияКредитов.FindAsync(id);

            if (погашениякредитов != null)
            {
                ПогашенияКредитов = погашениякредитов;
                _context.ПогашенияКредитов.Remove(ПогашенияКредитов);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }
    }
}
