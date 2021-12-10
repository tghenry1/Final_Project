using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Final_Project.Models;

namespace Final_Project.Pages_VideoGames
{
    public class DetailsModel : PageModel
    {
        private readonly Final_Project.Models.Context _context;

        public DetailsModel(Final_Project.Models.Context context)
        {
            _context = context;
        }

        public VideoGame VideoGame { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            VideoGame = await _context.VideoGame.FirstOrDefaultAsync(m => m.GameId == id);

            if (VideoGame == null)
            {
                return NotFound();
            }
            return Page();
        }
    }
}
