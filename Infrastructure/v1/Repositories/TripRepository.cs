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
            if (_appDbContext.Trips.Any() is false)
            {
                //Used in initial tests. Keeped for example 
                //_appDbContext.Trips.Add(new Trip() { Id = 1, TripName = "Item1", TripDescription = "viagem inicial 1" });
                //_appDbContext.Trips.Add(new Trip() { Id = 2, TripName = "Item2", TripDescription = " viagem inicial 2" });
                //_appDbContext.SaveChanges();
            }
        }

        public async Task AddAsync(Trip add)
        {
            add.Id = Guid.NewGuid();
            await _appDbContext.AddAsync(add);
            await _appDbContext.SaveChangesAsync();
        }

        public async Task DeleteAsync(Guid id)
        {
            Trip? trip = await _appDbContext.Trips.FindAsync(id) ??
                throw new Exception($"Remove trip {id} fail");

            _appDbContext.Remove(trip);
            _appDbContext.SaveChanges();
            return;
        }

        public async Task<IEnumerable<Trip>> GetAllAsync()
        {
            return await _appDbContext.Trips.ToListAsync();
        }

        public async Task<Trip?> GetByIdAsync(Guid id)
        {
            return await _appDbContext.Trips.FindAsync(id);
        }

        public async Task UpdateAsync(Trip update)
        {
            ArgumentNullException.ThrowIfNull(update);

            Trip? existingTrip = await _appDbContext.Trips.FindAsync(update.Id) ??
                throw new KeyNotFoundException($"Trip with ID {update.Id} not found.");

            _appDbContext.Entry(existingTrip).CurrentValues.SetValues(update);

            try
            {
                await _appDbContext.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException ex)
            {
                throw new Exception("Concurrency conflict occurred.", ex);
            }
        }
    }
}
