using APIiHR.Common;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace APIiHR.DataAccess.DatabaseContexts
{
    public class DbSysinfo_addContext : DbContext
    {
        public DbSet<Sysinfo_add> Sysinfo_addTable { get; set; }

        public DbSysinfo_addContext(DbContextOptions<DbSysinfo_addContext> options) : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Sysinfo_add>().ToTable("Sysinfo_add");
        }
    }
}
