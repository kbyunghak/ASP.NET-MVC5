using Microsoft.Data.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DataModel.Models
{
    public class PlayerContext : DbContext
    {
        public DbSet<Player> Players { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.Entity<Player>().HasKey(m => m.PlayerId);
            base.OnModelCreating(builder);
        }
    }

}
