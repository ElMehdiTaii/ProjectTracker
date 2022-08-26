using ProjectTracker.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectTracker.Repositories
{
    internal class UnitOfWork : IUnitOfWork
    {
        public UnitOfWork(ITaskRepository taskRepository)
        {
            Task = taskRepository;
        }
        public ITaskRepository Task { get; }
    }
}
