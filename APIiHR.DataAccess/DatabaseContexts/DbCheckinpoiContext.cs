using APIiHR.Common;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace APIiHR.DataAccess.DatabaseContexts
{
    public class DbCheckinpoiContext : DbContext
    {
        public DbSet<Checkinpoi> CheckinpoiTable { get; set; }

        public DbCheckinpoiContext(DbContextOptions<DbCheckinpoiContext> options) : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Checkinpoi>().ToTable("Checkinpoi");
        }
    }
}
