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

        public MoviesDataContext()
        {
        }

        public DbSet<Movie> Movies { get; set; }
    }
}
