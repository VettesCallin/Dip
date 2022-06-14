using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using DipWeb.Data;
using DipWeb.Model;

namespace DipWeb.Pages.Погашения_кредитов
{
    public class DetailsModel : PageModel
    {
        private readonly DipWeb.Data.ApplicationDbContext _context;

        public DetailsModel(DipWeb.Data.ApplicationDbContext context)
        {
            _context = context;
        }

      public ПогашенияКредитов ПогашенияКредитов { get; set; } = default!; 

        public async Task<IActionResult> OnGetAsync(Guid? id)
        {
            if (id == null || _context.ПогашенияКредитов == null)
            {
                return NotFound();
            }

            var погашениякредитов = await _context.ПогашенияКредитов.FirstOrDefaultAsync(m => m.ИдентификаторПогашения == id);
            if (погашениякредитов == null)
            {
                return NotFound();
            }
            else 
            {
                ПогашенияКредитов = погашениякредитов;
            }
            return Page();
        }
    }
}
