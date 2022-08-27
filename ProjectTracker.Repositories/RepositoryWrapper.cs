using ProjectTracker.Contracts;
using ProjectTracker.Entities.DBContext;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectTracker.Repositories
{
    public class RepositoryWrapper : IRepositoryWrapper
    {
        private RepositoryContext _repoContext;
        public RepositoryWrapper(RepositoryContext repoContext)
        {
            _repoContext = repoContext;
        }
        public IBoardRepository BoardRepository => throw new NotImplementedException();

        public ITaskRepository TaskRepository => throw new NotImplementedException();

        public IUserRepository UserRepository => throw new NotImplementedException();

        public IMessageRepository MessageRepository => throw new NotImplementedException();

        public async Task<bool> Save()
        {
            if (await _repoContext.SaveChangesAsync() > 0)
                return true;
            return false;
        }
    }
}
