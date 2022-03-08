#nullable disable
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Ageenko_lab1.Models;

namespace Ageenko_lab1.Data
{
    public class Ageenko_lab1Context : DbContext
    {
        public Ageenko_lab1Context (DbContextOptions<Ageenko_lab1Context> options)
            : base(options)
        {
        }

        public DbSet<Ageenko_lab1.Models.Movie> Movie { get; set; }
    }
}
