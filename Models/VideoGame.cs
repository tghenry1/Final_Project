using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Final_Project.Models
{
    public class VideoGame
    {
        [Key]
        public int GameId {get; set;}
        public string Title {get; set;}
        public string AvgCompletionTime {get; set;}
        public string Genre {get; set;}
        public string price {get; set;}
        public string AvgRating {get; set;}
    }

    public class VideoGameStreamer
    {
        public int GameId {get; set;}
        public int StreamerId {get; set;}
        public Streamer Streamer {get; set;}
        public VideoGame VideoGame {get; set;}
    }
}