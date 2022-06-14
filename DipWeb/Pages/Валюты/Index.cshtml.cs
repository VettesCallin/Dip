using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using DipWeb.Data;
using DipWeb.Model;

namespace DipWeb.Pages.Валюты
{
    public class IndexModel : PageModel
    {
        private readonly DipWeb.Data.ApplicationDbContext _context;

        public IndexModel(DipWeb.Data.ApplicationDbContext context)
        {
            _context = context;
        }

        public IList<Валюта> Валюта { get;set; } = default!;

        public async Task OnGetAsync()
        {
            if (_context.Валюта != null)
            {
                Валюта = await _context.Валюта.ToListAsync();
            }
        }
    }
}
