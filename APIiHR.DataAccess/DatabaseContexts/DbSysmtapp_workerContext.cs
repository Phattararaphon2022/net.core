using APIiHR.Common;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace APIiHR.DataAccess.DatabaseContexts
{
    public class DbSysmtapp_workerContext : DbContext
    {
        public DbSet<Sysmtapp_worker> Sysmtapp_workerTable { get; set; }

        public DbSysmtapp_workerContext(DbContextOptions<DbSysmtapp_workerContext> options) : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Sysmtapp_worker>().ToTable("Sysmtapp_worker");
        }
    }
}
