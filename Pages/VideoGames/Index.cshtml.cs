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
    public class IndexModel : PageModel
    {
        private readonly Final_Project.Models.Context _context;

        public IndexModel(Final_Project.Models.Context context)
        {
            _context = context;
        }

        public IList<VideoGame> VideoGame { get;set; }

        public async Task OnGetAsync()
        {
            VideoGame = await _context.VideoGame.ToListAsync();
        }
    }
}
