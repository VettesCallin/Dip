using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using DipWeb.Data;
using DipWeb.Model;

namespace DipWeb.Pages.Платежи_3м_лицам
{
    public class CreateModel : PageModel
    {
        private readonly DipWeb.Data.ApplicationDbContext _context;

        public CreateModel(DipWeb.Data.ApplicationDbContext context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
            return Page();
        }

        [BindProperty]
        public DipWeb.Model.Платежи_3м_лицам Платежи_3м_лицам { get; set; } = default!;
        

        // To protect from overposting attacks, see https://aka.ms/RazorPagesCRUD
        public async Task<IActionResult> OnPostAsync()
        {
          if (!ModelState.IsValid || _context.Платежи_3м_лицам == null || Платежи_3м_лицам == null)
            {
                return Page();
            }

            _context.Платежи_3м_лицам.Add(Платежи_3м_лицам);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}
