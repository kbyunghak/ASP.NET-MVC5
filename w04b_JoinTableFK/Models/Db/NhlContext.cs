using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CodeFirstStuff.Models.NHL;

namespace CodeFirstStuff.Models.Db
{
    public class NhlContext : DbContext
    {
        public NhlContext() : base("DefaultConnection")
        { }

        public DbSet<Team> Teams { get; set; }
        public DbSet<Player> Players { get; set; }
    }
}
