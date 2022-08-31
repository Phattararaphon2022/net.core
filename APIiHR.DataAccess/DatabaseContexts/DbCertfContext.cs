using APIiHR.Common;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace APIiHR.DataAccess.DatabaseContexts
{
    public class DbCertfContext : DbContext
    {
        public DbSet<Certf> CertfTable { get; set; }

        public DbCertfContext(DbContextOptions<DbCertfContext> options) : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Certf>().ToTable("Certf");
        }
    }
}
