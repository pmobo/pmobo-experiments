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
            // The code provided will print ‘Hello World’ to the console.
            // Press Ctrl+F5 (or go to Debug > Start Without Debugging) to run your app.            

            TrelloTask trelloTask = new TrelloTask()
            {
                Name = "Trello Task 1 ",
                Description = "Description da trello task 1",
                IsTrelloTask = true,
                BoardName = "Board teste",
                BoardId = "xyz"
            };

            TasksContext context = new TasksContext();
            context.Tasks.Add(trelloTask);
            context.SaveChanges();
            Console.WriteLine("Trello Task Inserted!");
            var t = context.Tasks.FirstOrDefault();
            if (t != null)
            {
                Console.WriteLine("Task != null, " + t.Name);
            }
            else
            {
                Console.WriteLine("Task == null");
            }
            Console.ReadKey();

            // Go to http://aka.ms/dotnet-get-started-console to continue learning how to build a console app! 
        }
    }
}
