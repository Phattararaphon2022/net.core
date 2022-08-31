using APIiHR.Common;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace APIiHR.DataAccess.DatabaseContexts
{
    public class DbSysmtappContext : DbContext
    {
        public DbSet<Sysmtapp> SysmtappTable { get; set; }

        public DbSysmtappContext(DbContextOptions<DbSysmtappContext> options) : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Sysmtapp>().ToTable("sysmtapp");
        }
    }
}
