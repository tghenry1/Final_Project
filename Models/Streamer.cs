using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Final_Project.Models
{
    public class Streamer
    {
        public int StreamerId {get; set;}
        [Required(ErrorMessage = "Name is required")]
        public string Name {get; set;}

        [Required(ErrorMessage = "Main Game is required")]

        public string MainGame {get; set;}

        public List<VideoGameStreamer> VideoGameStreamers {get; set;}
    }
}