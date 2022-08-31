using APIiHR.Common;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace APIiHR.DataAccess.DatabaseContexts
{
    public class DbSysleavetypeContext : DbContext
    {
        public DbSet<Sysleavetype> SysleavetypeTable { get; set; }

        public DbSysleavetypeContext(DbContextOptions<DbSysleavetypeContext> options) : base(options)
        {

        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Sysleavetype>().ToTable("Sysleavetype");
        }
    }
}
