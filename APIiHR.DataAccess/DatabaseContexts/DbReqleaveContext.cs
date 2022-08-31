using APIiHR.Common;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace APIiHR.DataAccess.DatabaseContexts
{
    public class DbReqleaveContext : DbContext
    {
        public DbSet<Reqleave> ReqleaveTable { get; set; }
        public DbReqleaveContext(DbContextOptions<DbReqleaveContext> options) : base(options) { }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Reqleave>().ToTable("Reqleave");
        }
    }
}
