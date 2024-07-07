using Core.v1.Entities;
using Core.v1.Interfaces;
using Infrastructure.Data;

namespace Infrastructure.v1.Repositories
{
    public class RegistrationRepository(AppDbContext appDbContext) : IRegistrationRepository
    {
        public readonly AppDbContext _appDbContext = appDbContext;

        public Task AddAsync(Registration add)
        {
            throw new NotImplementedException();
        }

        public Task DeleteAsync(Guid id)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<Registration>> GetAllAsync()
        {
            throw new NotImplementedException();
        }

        public Task<Registration?> GetByIdAsync(Guid id)
        {
            throw new NotImplementedException();
        }

        public Task<Registration> GetByNameAsync(string Name)
        {
            throw new NotImplementedException();
        }

        public Task UpdateAsync(Registration update)
        {
            throw new NotImplementedException();
        }
    }
}
