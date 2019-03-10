using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityFrameworkTablePerType.Model
{
    [Table("TrelloTask")]
    public class TrelloTask : Task
    {
        public bool IsTrelloTask { get; set; }
        public string BoardName { get; set; }
        public string BoardId { get; set; }
    }
}
