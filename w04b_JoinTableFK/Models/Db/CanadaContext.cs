using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CodeFirstStuff.Models.Canada;

namespace CodeFirstStuff.Models.Db
{
    public class CanadaContext : DbContext
    {
        public CanadaContext() : base("DefaultConnection")
        { }

        public DbSet<Province> Provinces { get; set; }
        public DbSet<City> Cities { get; set; }
    }
}
