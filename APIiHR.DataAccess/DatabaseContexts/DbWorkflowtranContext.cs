using APIiHR.Common;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace APIiHR.DataAccess.DatabaseContexts
{
    public class DbWorkflowtranContext : DbContext
    {
        public DbSet<Workflowtran> WorkflowtranTable { get; set; }

        public DbWorkflowtranContext(DbContextOptions<DbWorkflowtranContext> options) : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Workflowtran>().ToTable("Workflowtran");
        }
    }
}
