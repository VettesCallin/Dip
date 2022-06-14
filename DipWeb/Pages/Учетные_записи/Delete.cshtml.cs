using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using DipWeb.Data;
using DipWeb.Model;

namespace DipWeb.Pages.Учетные_записи
{
    public class DeleteModel : PageModel
    {
        private readonly DipWeb.Data.ApplicationDbContext _context;

        public DeleteModel(DipWeb.Data.ApplicationDbContext context)
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

            var учетныезаписи = await _context.УчетныеЗаписи.FirstOrDefaultAsync(m => m.ИдентификаторУчетнойЗаписи == id);

            if (учетныезаписи == null)
            {
                return NotFound();
            }
            else 
            {
                УчетныеЗаписи = учетныезаписи;
            }
            return Page();
        }

        public async Task<IActionResult> OnPostAsync(Guid? id)
        {
            if (id == null || _context.УчетныеЗаписи == null)
            {
                return NotFound();
            }
            var учетныезаписи = await _context.УчетныеЗаписи.FindAsync(id);

            if (учетныезаписи != null)
            {
                УчетныеЗаписи = учетныезаписи;
                _context.УчетныеЗаписи.Remove(УчетныеЗаписи);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }
    }
}
