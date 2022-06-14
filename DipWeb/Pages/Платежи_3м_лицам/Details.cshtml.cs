using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using DipWeb.Data;
using DipWeb.Model;

namespace DipWeb.Pages.Платежи_3м_лицам
{
    public class DetailsModel : PageModel
    {
        private readonly DipWeb.Data.ApplicationDbContext _context;

        public DetailsModel(DipWeb.Data.ApplicationDbContext context)
        {
            _context = context;
        }

      public DipWeb.Model.Платежи_3м_лицам Платежи_3м_лицам { get; set; } = default!; 

        public async Task<IActionResult> OnGetAsync(Guid? id)
        {
            if (id == null || _context.Платежи_3м_лицам == null)
            {
                return NotFound();
            }

            var платежи_3м_лицам = await _context.Платежи_3м_лицам.FirstOrDefaultAsync(m => m.ИдентификаторПлатежа3мЛицам == id);
            if (платежи_3м_лицам == null)
            {
                return NotFound();
            }
            else 
            {
                Платежи_3м_лицам = платежи_3м_лицам;
            }
            return Page();
        }
    }
}
