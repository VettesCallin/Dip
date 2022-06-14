using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using DipWeb.Data;
using DipWeb.Model;

namespace DipWeb.Pages.Банк
{
    public class DetailsModel : PageModel
    {
        private readonly DipWeb.Data.ApplicationDbContext _context;

        public DetailsModel(DipWeb.Data.ApplicationDbContext context)
        {
            _context = context;
        }

      public DipWeb.Model.Банк Банк { get; set; } = default!; 

        public async Task<IActionResult> OnGetAsync(Guid? id)
        {
            if (id == null || _context.Банк == null)
            {
                return NotFound();
            }

            var банк = await _context.Банк.FirstOrDefaultAsync(m => m.ИдентификаторБанка == id);
            if (банк == null)
            {
                return NotFound();
            }
            else 
            {
                Банк = банк;
            }
            return Page();
        }
    }
}
