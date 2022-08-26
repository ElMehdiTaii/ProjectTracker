using ProjectTracker.Entities.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectTracker.Contracts
{
    public interface IBoardRepository : IGenericRepository<Boards>
    {
    }
}
