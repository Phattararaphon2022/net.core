using APIiHR.Common;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace APIiHR.DataAccess.DatabaseContexts
{
    public class DbFilemanagerContext : DbContext
    {
        public DbSet<Filemanager> FilemanagerTable { get; set; }

        public DbFilemanagerContext(DbContextOptions<DbFilemanagerContext> options) : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Filemanager>().ToTable("Filemanager");
        }
    }
}
