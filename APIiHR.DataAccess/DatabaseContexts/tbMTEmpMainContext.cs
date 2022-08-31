using APIiHR.Common;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace APIiHR.DataAccess.DatabaseContexts
{
    public class tbMTEmpMainContext : DbContext
    {
        public DbSet<EmpMain> tbMTEmpMain { get; set; }

        public tbMTEmpMainContext(DbContextOptions<tbMTEmpMainContext> options) : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<EmpMain>().ToTable("tbMTEmpMain");
        }
    }
}
