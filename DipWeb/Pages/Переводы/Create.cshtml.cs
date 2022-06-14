using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using DipWeb.Data;
using DipWeb.Model;

namespace DipWeb.Pages.Переводы
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
        public DipWeb.Model.Переводы Переводы { get; set; } = default!;
        

        // To protect from overposting attacks, see https://aka.ms/RazorPagesCRUD
        public async Task<IActionResult> OnPostAsync()
        {
          if (!ModelState.IsValid || _context.Переводы == null || Переводы == null)
            {
                return Page();
            }

            _context.Переводы.Add(Переводы);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}
