using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityFrameworkTablePerType.Model
{
    [Table("Tasks")]
    public class Task
    {
        public Guid Id { get; set; }
        public bool IsCompleted { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public DateTime? CreatedOn { get; set; }

        public Task()
        {
            IsCompleted = false;
            CreatedOn = DateTime.Now;
        }

    }
}
