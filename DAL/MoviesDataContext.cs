using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace DAL
{
    class MoviesDataContext: DbContext
    {
        public MoviesDataContext (DbContextOptions options):base(options) { }

        public DbSet<Movie> Movies
    }
}
