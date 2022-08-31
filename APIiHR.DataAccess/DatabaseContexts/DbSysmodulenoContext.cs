using APIiHR.Common;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace APIiHR.DataAccess.DatabaseContexts
{
    public class DbSysmodulenoContext : DbContext
    {
        public DbSet<Sysmoduleno> SysmodulenoTable { get; set; }

        public DbSysmodulenoContext(DbContextOptions<DbSysmodulenoContext> options) : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Sysmoduleno>().ToTable("Sysmoduleno");
        }
    }
}
