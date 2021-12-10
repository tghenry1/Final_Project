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
                    if (context.VideoGameStreamer.Any())
                    {
                        return;
                    }

                    context.VideoGame.AddRange(
                        new VideoGame
                        {
                            Title = "League of Legends",
                            AvgCompletionTime = "45 minutes per game",
                            Genre = "MOBA",
                            Price = "Free",
                            AvgRating = 78
                        },
                        new VideoGame
                        {
                            Title = "Halo Infinite",
                            AvgCompletionTime = "18 hours",
                            Genre = "Action/Adventure",
                            Price = "$59.99",
                            AvgRating = 82
                        },
                        new VideoGame
                        {
                            Title = "Valorant",
                            AvgCompletionTime = "30 minutes per game",
                            Genre = "Action",
                            Price = "Free",
                            AvgRating = 80
                        },
                        new VideoGame
                        {
                            Title = "Apex Legends",
                            AvgCompletionTime = "30 minutes per game",
                            Genre = "Battle Royale",
                            Price = "Free",
                            AvgRating = 54
                        },
                        new VideoGame
                        {
                            Title = "Super Mario 64",
                            AvgCompletionTime = "20 minutes (speedrun)",
                            Genre = "Platformer",
                            Price = "Out of print",
                            AvgRating = 94
                        },
                        new VideoGame
                        {
                            Title = "World of Warcraft",
                            AvgCompletionTime = "2,000+ hours",
                            Genre = "MMORPG",
                            Price = "$15 monthly + expansions",
                            AvgRating = 93
                        },
                        new VideoGame
                        {
                            Title = "Madden",
                            AvgCompletionTime = "13 hours",
                            Genre = "Sports",
                            Price = "$59.99",
                            AvgRating = 63
                        },
                        new VideoGame
                        {
                            Title = "Final Fantasy XIV",
                            AvgCompletionTime = "1500+ hours",
                            Genre = "MMORPG",
                            Price = "$20 for initial game + $15 monthly + expansions",
                            AvgRating = 89
                        },
                        new VideoGame
                        {
                            Title = "Minecraft",
                            AvgCompletionTime = "60 hours",
                            Genre = "Sandbox",
                            Price = "$27",
                            AvgRating = 93
                        },
                        new VideoGame
                        {
                            Title = "Super Smash Bros. Melee",
                            AvgCompletionTime = "9.5 hours",
                            Genre = "Fighter",
                            Price = "Out of print",
                            AvgRating = 92
                        },
                        new VideoGame
                        {
                            Title = "Hearthstone",
                            AvgCompletionTime = "20 minutes per game",
                            Genre = "Card Battle",
                            Price = "Free + expansions",
                            AvgRating = 88
                        },
                        new VideoGame
                        {
                            Title = "Dead by Daylight",
                            AvgCompletionTime = "20 minutes per game",
                            Genre = "Survival Horror",
                            Price = "$19.99",
                            AvgRating = 71
                        },
                        new VideoGame
                        {
                            Title = "Counter-Strike: Global Offensive",
                            AvgCompletionTime = "30 minutes per game",
                            Genre = "Action",
                            Price = "Free",
                            AvgRating = 83
                        },
                        new VideoGame
                        {
                            Title = "Teamfight Tactics",
                            AvgCompletionTime = "30 minutes per game",
                            Genre = "Strategy",
                            Price = "Free",
                            AvgRating = 60
                        },
                        new VideoGame
                        {
                            Title = "Grand Theft Auto V",
                            AvgCompletionTime = "50 hours",
                            Genre = "Action/Adventure",
                            Price = "$15",
                            AvgRating = 97
                        },
                        new VideoGame
                        {
                            Title = "Pokemon: Brilliant Diamond/Shining Pearl",
                            AvgCompletionTime = "25 hours",
                            Genre = "RPG",
                            Price = "$59.99",
                            AvgRating = 74
                        },
                        new VideoGame
                        {
                            Title = "Golf with your Friends",
                            AvgCompletionTime = "30 minutes per game",
                            Genre = "Sports",
                            Price = "$14.99",
                            AvgRating = 66
                        },
                        new VideoGame
                        {
                            Title = "Old School Runescape",
                            AvgCompletionTime = "2400+ hours",
                            Genre = "MMORPG",
                            Price = "Free w/ optional monthly membership",
                            AvgRating = 87
                        },
                        new VideoGame
                        {
                            Title = "Animal Crossing: New Horizons",
                            AvgCompletionTime = "60 hours",
                            Genre = "Virtual Life",
                            Price = "$59.99",
                            AvgRating = 90
                        },
                        new VideoGame
                        {
                            Title = "Genshin Impact",
                            AvgCompletionTime = "47 hours",
                            Genre = "RPG",
                            Price = "Free",
                            AvgRating = 84
                        },
                        new VideoGame
                        {
                            Title = "DOTA 2",
                            AvgCompletionTime = "1.5 hours per game",
                            Genre = "MOBA",
                            Price = "Free",
                            AvgRating = 90
                        },
                        new VideoGame
                        {
                            Title = "Fortnite",
                            AvgCompletionTime = "30 minutes per game",
                            Genre = "Battle Royale",
                            Price = "Free",
                            AvgRating = 81
                        },
                        new VideoGame
                        {
                            Title = "Call of Duty: Warzone",
                            AvgCompletionTime = "30 minutes per game",
                            Genre = "Battle Royale",
                            Price = "Free",
                            AvgRating = 79
                        },
                        new VideoGame
                        {
                            Title = "Rust",
                            AvgCompletionTime = "90 hours",
                            Genre = "Action",
                            Price = "$39.99",
                            AvgRating = 69
                        },
                        new VideoGame
                        {
                            Title = "Escape Simulator",
                            AvgCompletionTime = "5 hours",
                            Genre = "Puzzle",
                            Price = "$11.99",
                            AvgRating = 75
                        }
                    );

                    context.Streamer.AddRange(
                        new Streamer
                        {
                            Name = "Sykkuno",
                            MainGame = "Golf with your Friends"
                        },
                        new Streamer
                        {
                            Name = "Asmongold",
                            MainGame = "Final Fantasy XIV"
                        },
                        new Streamer
                        {
                            Name = "Esfand",
                            MainGame = "World of Warcraft"
                        },
                        new Streamer
                        {
                            Name = "Mizkif",
                            MainGame = "Super Mario 64"
                        },
                        new Streamer
                        {
                            Name = "Mang0",
                            MainGame = "Super Smash Bros. Melee"
                        },
                        new Streamer
                        {
                            Name = "Ludwig",
                            MainGame = "Fortnite"
                        },
                        new Streamer
                        {
                            Name = "Tectone",
                            MainGame = "Genshin Impact"
                        },
                        new Streamer
                        {
                            Name = "AnthonyZ",
                            MainGame = "Grand Theft Auto V"
                        },
                        new Streamer
                        {
                            Name = "Lilypichu",
                            MainGame = "Teamfight Tactics"
                        },
                        new Streamer
                        {
                            Name = "Emiru",
                            MainGame = "League of Legends"
                        }
                    );

                    context.VideoGameStreamer.AddRange(
                        new VideoGameStreamer {GameId = 0, StreamerId = 0},
                        new VideoGameStreamer {GameId = 0, StreamerId = 8},
                        new VideoGameStreamer {GameId = 0, StreamerId = 9},
                        new VideoGameStreamer {GameId = 1, StreamerId = 0},
                        new VideoGameStreamer {GameId = 1, StreamerId = 7},
                        new VideoGameStreamer {GameId = 2, StreamerId = 0},
                        new VideoGameStreamer {GameId = 2, StreamerId = 4},
                        new VideoGameStreamer {GameId = 3, StreamerId = 5},
                        new VideoGameStreamer {GameId = 4, StreamerId = 3},
                        new VideoGameStreamer {GameId = 4, StreamerId = 9},
                        new VideoGameStreamer {GameId = 5, StreamerId = 1},
                        new VideoGameStreamer {GameId = 5, StreamerId = 2},
                        new VideoGameStreamer {GameId = 6, StreamerId = 2},
                        new VideoGameStreamer {GameId = 7, StreamerId = 1},
                        new VideoGameStreamer {GameId = 8, StreamerId = 0},
                        new VideoGameStreamer {GameId = 8, StreamerId = 5},
                        new VideoGameStreamer {GameId = 9, StreamerId = 4},
                        new VideoGameStreamer {GameId = 9, StreamerId = 5},
                        new VideoGameStreamer {GameId = 10, StreamerId = 6},
                        new VideoGameStreamer {GameId = 11, StreamerId = 0},
                        new VideoGameStreamer {GameId = 11, StreamerId = 3},
                        new VideoGameStreamer {GameId = 12, StreamerId = 4},
                        new VideoGameStreamer {GameId = 12, StreamerId = 7},
                        new VideoGameStreamer {GameId = 13, StreamerId = 0},
                        new VideoGameStreamer {GameId = 13, StreamerId = 8},
                        new VideoGameStreamer {GameId = 14, StreamerId = 0},
                        new VideoGameStreamer {GameId = 14, StreamerId = 7},
                        new VideoGameStreamer {GameId = 15, StreamerId = 9},
                        new VideoGameStreamer {GameId = 16, StreamerId = 0},
                        new VideoGameStreamer {GameId = 17, StreamerId = 3},
                        new VideoGameStreamer {GameId = 18, StreamerId = 0},
                        new VideoGameStreamer {GameId = 18, StreamerId = 8},
                        new VideoGameStreamer {GameId = 19, StreamerId = 0},
                        new VideoGameStreamer {GameId = 19, StreamerId = 6},
                        new VideoGameStreamer {GameId = 20, StreamerId = 4},
                        new VideoGameStreamer {GameId = 21, StreamerId = 5},
                        new VideoGameStreamer {GameId = 22, StreamerId = 7},
                        new VideoGameStreamer {GameId = 23, StreamerId = 0},
                        new VideoGameStreamer {GameId = 23, StreamerId = 7},
                        new VideoGameStreamer {GameId = 24, StreamerId = 0},
                        new VideoGameStreamer {GameId = 24, StreamerId = 8}
                    );

                    context.SaveChanges();
                }
        }
    }
}