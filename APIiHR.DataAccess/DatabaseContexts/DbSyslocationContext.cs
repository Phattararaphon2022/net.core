using APIiHR.Common;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace APIiHR.DataAccess.DatabaseContexts
{
    public class DbSyslocationContext : DbContext
    {
        public DbSet<Syslocation> SyslocationTable { get; set; }

        public DbSyslocationContext(DbContextOptions<DbSyslocationContext> options) : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Syslocation>().ToTable("Syslocation");
        }
    }
}
