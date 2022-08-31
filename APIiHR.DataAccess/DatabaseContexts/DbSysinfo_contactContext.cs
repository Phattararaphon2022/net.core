using APIiHR.Common;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace APIiHR.DataAccess.DatabaseContexts
{
    public class DbSysinfo_contactContext : DbContext
    {
        public DbSet<Sysinfo_contact> Sysinfo_contactTable { get; set; }

        public DbSysinfo_contactContext(DbContextOptions<DbSysinfo_contactContext> options) : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Sysinfo_contact>().ToTable("Sysinfo_contact");
        }
    }
}
