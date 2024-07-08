using Core.v1.Entities;

namespace Application.v1.Interfaces
{
    public interface ITripRegistrationService
    {
        Task<IEnumerable<Registration>> GetAllAsync();
        Task<Registration> GetAsync(Guid id);
    }
}
