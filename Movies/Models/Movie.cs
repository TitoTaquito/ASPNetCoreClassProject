using System;
using System.Collections.Generic;
using System.Text;

namespace Movies.Models
{
    class Movie
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Director { get; set; }
        public DateTime DateReleased { get; set; }
    }
}
