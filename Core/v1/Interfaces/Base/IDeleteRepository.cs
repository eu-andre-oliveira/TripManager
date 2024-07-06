namespace Core.v1.Interfaces.Base
{
    public interface IDeleteRepository<T>
    {
        Task DeleteAsync(int id);
    }
}
