using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace HomeWork26_07_19_2.Models
{
    public class CarsContext : DbContext
    {
        public CarsContext (DbContextOptions<CarsContext> options)
            : base(options)
        {
        }

        public DbSet<HomeWork26_07_19_2.Models.Car> Car { get; set; }
    }
}
