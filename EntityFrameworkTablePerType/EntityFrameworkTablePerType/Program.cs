using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EntityFrameworkTablePerType.Model;
using EntityFrameworkTablePerType.Data;

namespace EntityFrameworkTablePerType
{
    class Program
    {
        static void Main(string[] args)
        {
         
            TasksContext context = new TasksContext();

            var task = context.Tasks.FirstOrDefault(t => t.Name == "ProjecTask");
            if (task!=null)
            {
                Console.WriteLine("task exist");
            }
           
            Console.WriteLine("Task is project? ", task is ProjectTask);

            Console.ReadKey();
            
        }


        static void InsertTrelloTask(string name, TasksContext context)
        {
            TrelloTask trelloTask = new TrelloTask()
            {
                Id = Guid.NewGuid(),
                Name = name,
                Description = "Description da trello task 1",
                IsTrelloTask = true,
                BoardName = "Board teste",
                BoardId = "xyz"
            };
            context.Tasks.Add(trelloTask);
            context.SaveChanges();
        }

        static void InsertProjectTask(string name, TasksContext context)
        {
            ProjectTask projectTask = new ProjectTask()
            {
                Id = Guid.NewGuid(),
                Name = name,
                IsProjectTask = true,
                ProjectName = "My Project",
                PWAInstance = "ILABS"
            };
            context.Tasks.Add(projectTask);
            context.SaveChanges();
        }
    }
}
