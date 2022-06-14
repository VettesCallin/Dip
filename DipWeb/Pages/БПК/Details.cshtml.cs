using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using DipWeb.Data;
using DipWeb.Model;

namespace DipWeb.Pages.БПК
{
    public class DetailsModel : PageModel
    {
        private readonly DipWeb.Data.ApplicationDbContext _context;

        public DetailsModel(DipWeb.Data.ApplicationDbContext context)
        {
            _context = context;
        }

      public DipWeb.Model.БПК БПК { get; set; } = default!; 

        public async Task<IActionResult> OnGetAsync(Guid? id)
        {
            if (id == null || _context.БПК == null)
            {
                return NotFound();
            }

            var бпк = await _context.БПК.FirstOrDefaultAsync(m => m.ИдентификаторБПК == id);
            if (бпк == null)
            {
                return NotFound();
            }
            else 
            {
                БПК = бпк;
            }
            return Page();
        }
    }
}
