using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Final_Project.Models
{
    public class Streamer
    {
        public int StreamerId {get; set;}
        public string Name {get; set;}
        public string MainGame {get; set;}
        public string VOD {get; set;}

        public List<VideoGameStreamer> VideoGameStreamers {get; set;}
    }
}