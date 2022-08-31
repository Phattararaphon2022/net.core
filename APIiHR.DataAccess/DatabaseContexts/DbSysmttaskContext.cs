using APIiHR.Common;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace APIiHR.DataAccess.DatabaseContexts
{
    public class DbSysmttaskContext : DbContext
    {
        public DbSet<Sysmttask> SysmttaskTable { get; set; }

        public DbSysmttaskContext(DbContextOptions<DbSysmttaskContext> options) : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Sysmttask>().ToTable("Sysmttask");
        }
    }
}
