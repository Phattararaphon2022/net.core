using APIiHR.Common;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace APIiHR.DataAccess.DatabaseContexts
{
    public class DbReqotContext : DbContext
    {
        public DbSet<Reqot> ReqotTable { get; set; }

        public DbReqotContext(DbContextOptions<DbReqotContext> options) : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Reqot>().ToTable("Reqot");
        }
    }
}
