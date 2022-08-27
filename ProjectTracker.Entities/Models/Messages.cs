using ProjectTracker.Entities.Models.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectTracker.Entities.Models
{
    public class Messages : BaseEntity
    {
        public string Content { get; set; } = String.Empty;
        public int SenderId { get; set; }
        public int ReceiverId { get; set; }
        public DateTime SendingDate { get; set; }
        public TimeSpan SendingTime { get; set; }
        public bool IsRead { get; set; }
    }
}
