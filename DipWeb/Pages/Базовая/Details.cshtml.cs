using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using DipWeb.Data;
using DipWeb.Model;

namespace DipWeb.Pages.Базовая_величина
{
    public class DetailsModel : PageModel
    {
        private readonly DipWeb.Data.ApplicationDbContext _context;

        public DetailsModel(DipWeb.Data.ApplicationDbContext context)
        {
            _context = context;
        }

      public БазоваяВеличина БазоваяВеличина { get; set; } = default!; 

        public async Task<IActionResult> OnGetAsync(Guid? id)
        {
            if (id == null || _context.БазоваяВеличина == null)
            {
                return NotFound();
            }

            var базоваявеличина = await _context.БазоваяВеличина.FirstOrDefaultAsync(m => m.ИдентификаторБазовойВеличины == id);
            if (базоваявеличина == null)
            {
                return NotFound();
            }
            else 
            {
                БазоваяВеличина = базоваявеличина;
            }
            return Page();
        }
    }
}
