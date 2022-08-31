using APIiHR.Common;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace APIiHR.DataAccess.DatabaseContexts
{
    public class DbTeamlineContext : DbContext
    {
        public DbSet<Teamline> TeamlineTable { get; set; }

        public DbTeamlineContext(DbContextOptions<DbTeamlineContext> options) : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Teamline>().ToTable("Teamline");
        }
    }
}
