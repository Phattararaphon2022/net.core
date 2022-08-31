using APIiHR.Common;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace APIiHR.DataAccess.DatabaseContexts
{
    public class DbTeammasterContext : DbContext
    {
        public DbSet<Teammaster> TeammasterTable { get; set; }

        public DbTeammasterContext(DbContextOptions<DbTeammasterContext> options) : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Teammaster>().ToTable("Teammaster");
        }
    }
}
