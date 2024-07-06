namespace Core.v1.Interfaces.Base
{
    public interface IAddRepository<T>
    {
        Task AddAsync(T add);
    }
}
