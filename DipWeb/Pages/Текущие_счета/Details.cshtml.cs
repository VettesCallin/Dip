using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using DipWeb.Data;
using DipWeb.Model;

namespace DipWeb.Pages.Текущие_счета
{
    public class DetailsModel : PageModel
    {
        private readonly DipWeb.Data.ApplicationDbContext _context;

        public DetailsModel(DipWeb.Data.ApplicationDbContext context)
        {
            _context = context;
        }

      public ТекущиеСчета ТекущиеСчета { get; set; } = default!; 

        public async Task<IActionResult> OnGetAsync(Guid? id)
        {
            if (id == null || _context.ТекущиеСчета == null)
            {
                return NotFound();
            }

            var текущиесчета = await _context.ТекущиеСчета.FirstOrDefaultAsync(m => m.ИдентификаторТекущегоСчета == id);
            if (текущиесчета == null)
            {
                return NotFound();
            }
            else 
            {
                ТекущиеСчета = текущиесчета;
            }
            return Page();
        }
    }
}
