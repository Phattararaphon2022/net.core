using APIiHR.Common;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace APIiHR.DataAccess.DatabaseContexts
{
    public class DbWorkflowtranlogContext : DbContext
    {
        public DbSet<Workflowtranlog> WorkflowtranlogTable { get; set; }

        public DbWorkflowtranlogContext(DbContextOptions<DbWorkflowtranlogContext> options) : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Workflowtranlog>().ToTable("Workflowtranlog");
        }
    }
}
