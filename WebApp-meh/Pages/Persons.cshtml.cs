using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using WebApp_meh;
using WebApp_meh.Data;

namespace WebApp_meh.Pages
{
    public class PersonsModel : PageModel
    {
        private readonly WebApp_meh.Data.appDbContext _context;

        public PersonsModel(WebApp_meh.Data.appDbContext context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
            return Page();
        }

        [BindProperty]
        public Persons Persons { get; set; } = default!;
        

        // To protect from overposting attacks, see https://aka.ms/RazorPagesCRUD
        public async Task<IActionResult> OnPostAsync()
        {
          if (!ModelState.IsValid || _context.Persons == null || Persons == null)
            {
                return Page();
            }

            _context.Persons.Add(Persons);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}
