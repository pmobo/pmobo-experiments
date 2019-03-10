using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;

using EntityFrameworkTablePerType.Model;
namespace EntityFrameworkTablePerType.Data
{
    class TasksContext : DbContext
    {
        
        public TasksContext(): base("TasksContext")
        {

        }

        public DbSet<Task> Tasks { get; set; }

        /*
         * Using Fluent API
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Task>().ToTable("Tasks");
            modelBuilder.Entity<TrelloTask>().ToTable("TrelloTask");
            modelBuilder.Entity<ProjectTask>().ToTable("ProjectTask");
            base.OnModelCreating(modelBuilder);
        }
        */

    }
}
