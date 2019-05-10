using System;
using System.Collections.Generic;
using System.Text;

namespace DAL.DBModels
{
    public class Movie
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Director { get; set; }
        public string DateReleased { get; set; }
    }
}
