using APIiHR.Common;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace APIiHR.DataAccess.DatabaseContexts
{
    public class DbReqinfoContext : DbContext
    {
        public DbSet<Reqinfo> ReqinfoTable { get; set; }

        public DbReqinfoContext(DbContextOptions<DbReqinfoContext> options) : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Reqinfo>().ToTable("Reqinfo");
        }
    }
}
