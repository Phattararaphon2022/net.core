using APIiHR.Common;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace APIiHR.DataAccess.DatabaseContexts
{
    public class DbReqchgshiftContext : DbContext
    {
        public DbSet<Reqchgshift> ReqchgshiftTable { get; set; }
        public DbReqchgshiftContext(DbContextOptions<DbReqchgshiftContext> options) : base(options) { }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Reqchgshift>().ToTable("Reqchgshift");
        }
    }
}
