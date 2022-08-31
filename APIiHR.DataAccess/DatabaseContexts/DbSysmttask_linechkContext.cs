using APIiHR.Common;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace APIiHR.DataAccess.DatabaseContexts
{
    public class DbSysmttask_linechkContext : DbContext
    {
        public DbSet<Sysmttask_linechk> Sysmttask_linechkTable { get; set; }

        public DbSysmttask_linechkContext(DbContextOptions<DbSysmttask_linechkContext> options) : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Sysmttask_linechk>().ToTable("Sysmttask_linechk");
        }
    }
}
