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
    public class IndexModel : PageModel
    {
        private readonly DipWeb.Data.ApplicationDbContext _context;

        public IndexModel(DipWeb.Data.ApplicationDbContext context)
        {
            _context = context;
        }

        public IList<DipWeb.Model.Платежи_3м_лицам> Платежи_3м_лицам { get;set; } = default!;

        public async Task OnGetAsync()
        {
            if (_context.Платежи_3м_лицам != null)
            {
                Платежи_3м_лицам = await _context.Платежи_3м_лицам.ToListAsync();
            }
        }
    }
}
