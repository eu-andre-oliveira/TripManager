using Core.v1.Entities;
using Core.v1.Interfaces;
using Infrastructure.Data;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.v1.Repositories
{
    public class TripRepository : ITripRepository
    {
        public readonly AppDbContext _appDbContext;

        public TripRepository(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
            if (_appDbContext.Trips.Count() == 0)
            {
                _appDbContext.Trips.Add(new Trip() { Id = 1, TripName = "Item1", TripDescription = "viagem inicial 1" });
                _appDbContext.Trips.Add(new Trip() { Id = 2, TripName = "Item2", TripDescription = " viagem inicial 2" });
                _appDbContext.SaveChanges();
            }
        }

        public Task AddAsync(Trip add)
        {
            throw new NotImplementedException();
        }

        public Task DeleteAsync(int id)
        {
            throw new NotImplementedException();
        }

        public async Task<IEnumerable<Trip>> GetAllAsync()
        {
            return await _appDbContext.Trips.ToListAsync();
        }

        public Task<Trip> GetByIdAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task UpdateAsync(Trip update)
        {
            throw new NotImplementedException();
        }
    }
}
