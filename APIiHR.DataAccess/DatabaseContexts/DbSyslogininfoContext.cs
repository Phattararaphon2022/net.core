using APIiHR.Common;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace APIiHR.DataAccess.DatabaseContexts
{
    public class DbSyslogininfoContext : DbContext
    {
        public DbSet<Syslogininfo> SyslogininfoTable { get; set; }

        public DbSyslogininfoContext(DbContextOptions<DbSyslogininfoContext> options) : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Syslogininfo>().ToTable("Syslogininfo");
        }
    }
}
