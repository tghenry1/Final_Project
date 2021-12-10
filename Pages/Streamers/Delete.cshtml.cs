using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Final_Project.Models;

namespace Final_Project.Pages_Streamers
{
    public class DeleteModel : PageModel
    {
        private readonly Final_Project.Models.Context _context;

        public DeleteModel(Final_Project.Models.Context context)
        {
            _context = context;
        }

        [BindProperty]
        public Streamer Streamer { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Streamer = await _context.Streamer.FirstOrDefaultAsync(m => m.StreamerId == id);

            if (Streamer == null)
            {
                return NotFound();
            }
            return Page();
        }

        public async Task<IActionResult> OnPostAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Streamer = await _context.Streamer.FindAsync(id);

            if (Streamer != null)
            {
                _context.Streamer.Remove(Streamer);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }
    }
}
