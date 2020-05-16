using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using HelloWorldJNodz.Models;

namespace HelloWorldJNodz.Data
{
    public class AnimalContext : DbContext
    {
        public AnimalContext (DbContextOptions<AnimalContext> options)
            : base(options)
        {
        }

        public DbSet<HelloWorldJNodz.Models.Animal> Animal { get; set; }

        public DbSet<HelloWorldJNodz.Models.Species> Species { get; set; }
    }
}
