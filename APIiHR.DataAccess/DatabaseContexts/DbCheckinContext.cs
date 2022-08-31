using APIiHR.Common;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace APIiHR.DataAccess.DatabaseContexts
{
    public class DbCheckinContext : DbContext
    {
        public DbSet<Checkin> CheckinTable { get; set; }

        public DbCheckinContext(DbContextOptions<DbCheckinContext> options) : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Checkin>().ToTable("Checkin");
        }
    }
}
