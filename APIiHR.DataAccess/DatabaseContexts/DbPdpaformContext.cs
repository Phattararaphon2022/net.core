using APIiHR.Common;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace APIiHR.DataAccess.DatabaseContexts
{
    public class DbPdpaformContext : DbContext
    {
        public DbSet<Pdpaform> PdpaformTable { get; set; }

        public DbPdpaformContext(DbContextOptions<DbPdpaformContext> options) : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Pdpaform>().ToTable("Pdpaform");
        }
    }
}
