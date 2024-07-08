using Application.v1.Interfaces;
using Core.v1.Entities;

namespace Application.v1.Service
{
    public class TripRegistrationService : ITripRegistrationService
    {
        public Task<IEnumerable<Registration>> GetAllAsync()
        {
            throw new NotImplementedException();
        }

        public Task<Registration> GetAsync(Guid id)
        {
            throw new NotImplementedException();
        }
    }
}
