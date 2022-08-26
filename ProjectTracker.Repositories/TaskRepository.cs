using ProjectTracker.Contracts;

namespace ProjectTracker.Repositories
{
    public class TaskRepository : ITaskRepository
    {
        public Task<int> Add(Task entity)
        {
            throw new NotImplementedException();
        }

        public Task<int> Add(IEnumerable<Task> entities)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<Task>> All()
        {
            throw new NotImplementedException();
        }

        public Task<Task> FindAsync(object pksFields)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<Task>> GetData(string qry, object parameters)
        {
            throw new NotImplementedException();
        }

        public Task<int> InstertOrUpdate(Task entity, object pks)
        {
            throw new NotImplementedException();
        }

        public Task Remove(object key)
        {
            throw new NotImplementedException();
        }

        public Task<int> Update(Task entity, object pks)
        {
            throw new NotImplementedException();
        }
    }
}
