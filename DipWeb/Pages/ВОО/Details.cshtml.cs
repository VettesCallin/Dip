using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using DipWeb.Data;
using DipWeb.Model;

namespace DipWeb.Pages.ВОО
{
    public class DetailsModel : PageModel
    {
        private readonly DipWeb.Data.ApplicationDbContext _context;

        public DetailsModel(DipWeb.Data.ApplicationDbContext context)
        {
            _context = context;
        }

      public DipWeb.Model.ВОО ВОО { get; set; } = default!; 

        public async Task<IActionResult> OnGetAsync(Guid? id)
        {
            if (id == null || _context.ВОО == null)
            {
                return NotFound();
            }

            var воо = await _context.ВОО.FirstOrDefaultAsync(m => m.ИдентификаторВОО == id);
            if (воо == null)
            {
                return NotFound();
            }
            else 
            {
                ВОО = воо;
            }
            return Page();
        }
    }
}
