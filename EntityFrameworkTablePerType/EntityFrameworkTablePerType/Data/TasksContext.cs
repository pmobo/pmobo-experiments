using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityFrameworkTablePerType.Data
{
    class TasksContext : DbContext
    {
        public DbSet<Task> Tasks { get; set; }
        public TasksContext(): base("TasksContext")
        {

        }
    }
}
