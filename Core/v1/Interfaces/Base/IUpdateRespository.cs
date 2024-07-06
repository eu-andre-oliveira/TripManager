namespace Core.v1.Interfaces.Base
{
    public interface IUpdateRespository<T>
    {
        Task UpdateAsync(T update);
    }
}
