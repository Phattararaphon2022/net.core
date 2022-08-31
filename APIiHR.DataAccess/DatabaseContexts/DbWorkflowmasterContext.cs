﻿using APIiHR.Common;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace APIiHR.DataAccess.DatabaseContexts
{
    public class DbWorkflowmasterContext : DbContext
    {
        public DbSet<Workflowmaster> WorkflowmasterTable { get; set; }

        public DbWorkflowmasterContext(DbContextOptions<DbWorkflowmasterContext> options) : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Workflowmaster>().ToTable("Workflowmaster");
        }
    }
}
