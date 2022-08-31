using APIiHR.Common;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace APIiHR.DataAccess.DatabaseContexts
{
    public class DbApptransContext : DbContext
    {
        public DbSet<Apptrans> ApptransTable { get; set; }

        public DbApptransContext(DbContextOptions<DbApptransContext> options) : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Apptrans>().ToTable("Apptrans");
        }
    }
}
