using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using DipWeb.Data;
using DipWeb.Model;

namespace DipWeb.Pages.Страхование
{
    public class DetailsModel : PageModel
    {
        private readonly DipWeb.Data.ApplicationDbContext _context;

        public DetailsModel(DipWeb.Data.ApplicationDbContext context)
        {
            _context = context;
        }

      public DipWeb.Model.Страхование Страхование { get; set; } = default!; 

        public async Task<IActionResult> OnGetAsync(Guid? id)
        {
            if (id == null || _context.Страхование == null)
            {
                return NotFound();
            }

            var страхование = await _context.Страхование.FirstOrDefaultAsync(m => m.ИдентификаторСтрахования == id);
            if (страхование == null)
            {
                return NotFound();
            }
            else 
            {
                Страхование = страхование;
            }
            return Page();
        }
    }
}
