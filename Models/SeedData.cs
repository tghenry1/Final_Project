using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Linq;

namespace Final_Project.Models
{
    public static class SeedData
    {
        public static void Initialize (IServiceProvider serviceProvider)
        {
            using (var context = new Context(
                serviceProvider.GetRequiredService<DbContextOptions<Context>>()))
                {
                    if (context.VideoGame.Any())
                    {
                        return;
                    }
                    if (context.Streamer.Any())
                    {
                        return;
                    }

                    context.VideoGame.AddRange(

                    );

                    context.Streamer.AddRange(
                        
                    );

                    context.SaveChanges();
                }
        }
    }
}