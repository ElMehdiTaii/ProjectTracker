namespace ProjectTracker.Contracts
{
    public interface IUnitOfWork
    {
        ITaskRepository Task { get; }
    }
}
