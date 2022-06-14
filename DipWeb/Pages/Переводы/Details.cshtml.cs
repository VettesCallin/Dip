using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using DipWeb.Data;
using DipWeb.Model;

namespace DipWeb.Pages.Переводы
{
    public class DetailsModel : PageModel
    {
        private readonly DipWeb.Data.ApplicationDbContext _context;

        public DetailsModel(DipWeb.Data.ApplicationDbContext context)
        {
            _context = context;
        }

      public DipWeb.Model.Переводы Переводы { get; set; } = default!; 

        public async Task<IActionResult> OnGetAsync(Guid? id)
        {
            if (id == null || _context.Переводы == null)
            {
                return NotFound();
            }

            var переводы = await _context.Переводы.FirstOrDefaultAsync(m => m.ИдентификаторПеревода == id);
            if (переводы == null)
            {
                return NotFound();
            }
            else 
            {
                Переводы = переводы;
            }
            return Page();
        }
    }
}
