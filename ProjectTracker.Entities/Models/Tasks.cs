using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectTracker.Entities.Models
{
    public class Tasks
    {
        public int TaskId { get; set; }
        public int TaskPriority { get; set; } 
        public string TaskDescription { get; set; } = String.Empty;
        public DateTime TaskStartDate { get; set; }
        public DateTime TaskEndDate { get; set; }
        public int TaskStatus { get; set; }
        public int BoardId { get; set; }
        public string TaskName { get; set; } = String.Empty;
    }
}
