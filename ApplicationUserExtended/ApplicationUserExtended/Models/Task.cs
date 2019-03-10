using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ApplicationUserExtended.Models
{
    public class Task
    {
        public string ID { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public DateTime CreatedOn { get; set; }
    }
}