using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using DipWeb.Data;
using DipWeb.Model;

namespace DipWeb.Pages.Текущие_счета
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
        public ТекущиеСчета ТекущиеСчета { get; set; } = default!;
        

        // To protect from overposting attacks, see https://aka.ms/RazorPagesCRUD
        public async Task<IActionResult> OnPostAsync()
        {
          if (!ModelState.IsValid || _context.ТекущиеСчета == null || ТекущиеСчета == null)
            {
                return Page();
            }

            _context.ТекущиеСчета.Add(ТекущиеСчета);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}
