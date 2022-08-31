using APIiHR.Common;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace APIiHR.DataAccess.DatabaseContexts
{
    public class tbMTWebUserContext : DbContext
    {
        public DbSet<Authen> tbMTWebUser { get; set; }

        public tbMTWebUserContext(DbContextOptions<tbMTWebUserContext> options) : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Authen>().ToTable("tbMTWebUser");
        }
    }
}
