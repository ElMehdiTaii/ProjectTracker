
namespace ProjectTracker.Contracts
{
    public interface IRepositoryWrapper
    {
        public IBoardRepository BoardRepository { get; }
        public ITaskRepository TaskRepository { get; }
        public IUserRepository UserRepository { get; }
        public IMessageRepository MessageRepository { get; }
        Task<bool> Save();
    }
}
