using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectTracker.Entities.Models
{
    public class Boards
    {
        public int BoardId { get; set; }
        public string BoardName { get; set; } = String.Empty;
        public int AccountId { get; set; }
    }
}
