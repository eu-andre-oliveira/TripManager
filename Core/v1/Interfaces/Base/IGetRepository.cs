namespace Core.v1.Interfaces.Base
{
    public interface IGetRepository<T>
    {
        Task<IEnumerable<T>> GetAllAsync();
        Task<T?> GetByIdAsync(Guid id);
    }
}
