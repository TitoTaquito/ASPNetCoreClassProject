using DAL.DBModels;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace DAL
{
    public class MoviesDataContext: DbContext
    {
        public MoviesDataContext (DbContextOptions options):base(options) { }


        public DbSet<Movie> Movie { get; set; }
    }
}
