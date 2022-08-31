using APIiHR.Common;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace APIiHR.DataAccess.DatabaseContexts
{
    public class DbSysuserempContext : DbContext
    {
        public DbSet<Sysuseremp> SysuserempTable { get; set; }

        public DbSysuserempContext(DbContextOptions<DbSysuserempContext> options) : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Sysuseremp>().ToTable("Sysuseremp");
        }
    }
}
