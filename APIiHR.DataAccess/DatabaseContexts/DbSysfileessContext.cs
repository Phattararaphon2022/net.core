using APIiHR.Common;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace APIiHR.DataAccess.DatabaseContexts
{
    public class DbSysfileessContext : DbContext
    {
        public DbSet<Sysfileess> SysfileessTable { get; set; }

        public DbSysfileessContext(DbContextOptions<DbSysfileessContext> options) : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Sysfileess>().ToTable("Sysfileess");
        }
    }
}
