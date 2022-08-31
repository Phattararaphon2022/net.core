using APIiHR.Common;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace APIiHR.DataAccess.DatabaseContexts
{
    public class DbSysinfo_cardContext : DbContext
    {
        public DbSet<Sysinfo_card> Sysinfo_cardTable { get; set; }

        public DbSysinfo_cardContext(DbContextOptions<DbSysinfo_cardContext> options) : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Sysinfo_card>().ToTable("Sysinfo_card");
        }
    }
}
