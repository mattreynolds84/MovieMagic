using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MovieMagic.Models;

namespace MovieMagic
{
    public class MovieContext:DbContext
    {
        public DbSet<Movie> Movies { get; set; }

    }
}
