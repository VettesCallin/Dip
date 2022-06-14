using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using DipWeb.Data;
using DipWeb.Model;

namespace DipWeb.Pages.Кредитование
{
    public class DetailsModel : PageModel
    {
        private readonly DipWeb.Data.ApplicationDbContext _context;

        public DetailsModel(DipWeb.Data.ApplicationDbContext context)
        {
            _context = context;
        }

      public DipWeb.Model.Кредитование Кредитование { get; set; } = default!; 

        public async Task<IActionResult> OnGetAsync(Guid? id)
        {
            if (id == null || _context.Кредитование == null)
            {
                return NotFound();
            }

            var кредитование = await _context.Кредитование.FirstOrDefaultAsync(m => m.ИдентификаторКредитования == id);
            if (кредитование == null)
            {
                return NotFound();
            }
            else 
            {
                Кредитование = кредитование;
            }
            return Page();
        }
    }
}
