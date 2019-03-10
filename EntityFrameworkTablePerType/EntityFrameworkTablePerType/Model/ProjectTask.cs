using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EntityFrameworkTablePerType.Model
{
    [Table("ProjectTask")]
    public class ProjectTask : Task
    {
        public bool IsProjectTask { get; set; }
        public string ProjectName { get; set; }
        public string PWAInstance { get; set; }

    }
}
