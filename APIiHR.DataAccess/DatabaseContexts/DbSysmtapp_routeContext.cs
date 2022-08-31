using APIiHR.Common;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace APIiHR.DataAccess.DatabaseContexts
{
    public class DbSysmtapp_routeContext : DbContext
    {
        public DbSet<Sysmtapp_route> Sysmtapp_routeTable { get; set; }

        public DbSysmtapp_routeContext(DbContextOptions<DbSysmtapp_routeContext> options) : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Sysmtapp_route>().ToTable("Sysmtapp_route");
        }
    }
}
