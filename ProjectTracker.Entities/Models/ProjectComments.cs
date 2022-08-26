using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectTracker.Entities.Models
{
    public class ProjectComments
    {
        public int Id { get; set; }
        public string Comment { get; set; } = string.Empty;
        public int SubmitedBy { get; set; }
        public DateTime SubmitedAt { get; set; }
        public int PKey { get; set; }
        public string type { get; set; } = string.Empty;
    }
}
