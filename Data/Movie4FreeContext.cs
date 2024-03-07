using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Movie4Free.Models;

namespace Movie4Free.Data
{
    public class Movie4FreeContext : DbContext
    {
        public Movie4FreeContext (DbContextOptions<Movie4FreeContext> options)
            : base(options)
        {
        }

        public DbSet<Movie4Free.Models.Movie> Movie { get; set; } = default!;
    }
}
