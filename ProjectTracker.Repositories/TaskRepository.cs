using ProjectTracker.Contracts;
using ProjectTracker.Entities.DBContext;
using ProjectTracker.Entities.Models;

namespace ProjectTracker.Repositories
{
    public class TaskRepository : RepositoryBase<Tasks>, ITaskRepository
    {
        public TaskRepository(RepositoryContext repositoryContext) : base(repositoryContext)
        {
        }
    }
}
