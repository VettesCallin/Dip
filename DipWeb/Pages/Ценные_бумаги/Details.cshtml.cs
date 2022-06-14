using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using DipWeb.Data;
using DipWeb.Model;

namespace DipWeb.Pages.Ценные_бумаги
{
    public class DetailsModel : PageModel
    {
        private readonly DipWeb.Data.ApplicationDbContext _context;

        public DetailsModel(DipWeb.Data.ApplicationDbContext context)
        {
            _context = context;
        }

      public ЦенныеБумаги ЦенныеБумаги { get; set; } = default!; 

        public async Task<IActionResult> OnGetAsync(Guid? id)
        {
            if (id == null || _context.ЦенныеБумаги == null)
            {
                return NotFound();
            }

            var ценныебумаги = await _context.ЦенныеБумаги.FirstOrDefaultAsync(m => m.ИдентификаторЦеннойБумаги == id);
            if (ценныебумаги == null)
            {
                return NotFound();
            }
            else 
            {
                ЦенныеБумаги = ценныебумаги;
            }
            return Page();
        }
    }
}
