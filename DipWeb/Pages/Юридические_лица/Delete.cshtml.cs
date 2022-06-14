using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using DipWeb.Data;
using DipWeb.Model;

namespace DipWeb.Pages.Юридические_лица
{
    public class DeleteModel : PageModel
    {
        private readonly DipWeb.Data.ApplicationDbContext _context;

        public DeleteModel(DipWeb.Data.ApplicationDbContext context)
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

            var юридическиелица = await _context.ЮридическиеЛица.FirstOrDefaultAsync(m => m.ИдентификаторЮридическогоЛица == id);

            if (юридическиелица == null)
            {
                return NotFound();
            }
            else 
            {
                ЮридическиеЛица = юридическиелица;
            }
            return Page();
        }

        public async Task<IActionResult> OnPostAsync(Guid? id)
        {
            if (id == null || _context.ЮридическиеЛица == null)
            {
                return NotFound();
            }
            var юридическиелица = await _context.ЮридическиеЛица.FindAsync(id);

            if (юридическиелица != null)
            {
                ЮридическиеЛица = юридическиелица;
                _context.ЮридическиеЛица.Remove(ЮридическиеЛица);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }
    }
}
