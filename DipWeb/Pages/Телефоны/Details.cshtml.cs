using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using DipWeb.Data;
using DipWeb.Model;

namespace DipWeb.Pages.Телефоны
{
    public class DetailsModel : PageModel
    {
        private readonly DipWeb.Data.ApplicationDbContext _context;

        public DetailsModel(DipWeb.Data.ApplicationDbContext context)
        {
            _context = context;
        }

      public Телефон Телефон { get; set; } = default!; 

        public async Task<IActionResult> OnGetAsync(Guid? id)
        {
            if (id == null || _context.Телефоны == null)
            {
                return NotFound();
            }

            var телефон = await _context.Телефоны.FirstOrDefaultAsync(m => m.ИдентификаторТелефона == id);
            if (телефон == null)
            {
                return NotFound();
            }
            else 
            {
                Телефон = телефон;
            }
            return Page();
        }
    }
}
