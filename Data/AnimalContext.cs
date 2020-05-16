using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using SSuwalaBonjourLeMonde.Models;

namespace SSuwalaBonjourLeMonde.Data
{
    public class AnimalContext : DbContext
    {
        public AnimalContext (DbContextOptions<AnimalContext> options)
            : base(options)
        {
        }

        public DbSet<SSuwalaBonjourLeMonde.Models.Animal> Animal { get; set; }
    }
}
