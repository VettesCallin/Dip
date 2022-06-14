using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using DipWeb.Data;
using DipWeb.Model;

namespace DipWeb.Pages.Физические_лица
{
    public class DetailsModel : PageModel
    {
        private readonly DipWeb.Data.ApplicationDbContext _context;

        public DetailsModel(DipWeb.Data.ApplicationDbContext context)
        {
            _context = context;
        }

      public ФизическиеЛица ФизическиеЛица { get; set; } = default!; 

        public async Task<IActionResult> OnGetAsync(Guid? id)
        {
            if (id == null || _context.ФизическиеЛица == null)
            {
                return NotFound();
            }

            var физическиелица = await _context.ФизическиеЛица.FirstOrDefaultAsync(m => m.ИдентификаторФизическогоЛица == id);
            if (физическиелица == null)
            {
                return NotFound();
            }
            else 
            {
                ФизическиеЛица = физическиелица;
            }
            return Page();
        }
    }
}
