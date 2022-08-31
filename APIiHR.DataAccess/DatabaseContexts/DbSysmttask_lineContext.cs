using APIiHR.Common;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace APIiHR.DataAccess.DatabaseContexts
{
    public class DbSysmttask_lineContext : DbContext
    {
        public DbSet<Sysmttask_line> Sysmttask_lineTable { get; set; }

        public DbSysmttask_lineContext(DbContextOptions<DbSysmttask_lineContext> options) : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Sysmttask_line>().ToTable("Sysmttask_line");
        }
    }
}
