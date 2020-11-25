using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Rendes_Denisa_Lab8.Models;

namespace Rendes_Denisa_Lab8.Data
{
    public class Rendes_Denisa_Lab8Context : DbContext
    {
        public Rendes_Denisa_Lab8Context (DbContextOptions<Rendes_Denisa_Lab8Context> options)
            : base(options)
        {
        }

        public DbSet<Rendes_Denisa_Lab8.Models.Book> Book { get; set; }

        public DbSet<Rendes_Denisa_Lab8.Models.Publisher> Publisher { get; set; }

        public DbSet<Rendes_Denisa_Lab8.Models.Category> Category { get; set; }
    }
}
