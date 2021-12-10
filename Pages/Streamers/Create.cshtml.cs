using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Final_Project.Models;

namespace Final_Project.Pages_Streamers
{
    public class CreateModel : PageModel
    {
        private readonly Final_Project.Models.Context _context;

        public CreateModel(Final_Project.Models.Context context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
            return Page();
        }

        [BindProperty]
        public Streamer Streamer { get; set; }

        // To protect from overposting attacks, see https://aka.ms/RazorPagesCRUD
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Streamer.Add(Streamer);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}
