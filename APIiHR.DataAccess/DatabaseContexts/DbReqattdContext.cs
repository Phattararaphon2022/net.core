using APIiHR.Common;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace APIiHR.DataAccess.DatabaseContexts
{
    public class DbReqattdContext : DbContext
    {
        public DbSet<Reqattd> ReqattdTable { get; set; }

        public DbReqattdContext(DbContextOptions<DbReqattdContext> options) : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Reqattd>().ToTable("Reqattd");
        }
    }
}
