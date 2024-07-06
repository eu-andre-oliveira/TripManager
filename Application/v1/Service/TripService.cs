using Application.v1.Interfaces;
using Application.v1.ViewModels.Requests.Trips;
using Core.v1.Entities;
using Core.v1.Interfaces;

namespace Application.v1.Service
{
    public class TripService : ITripService
    {
        private readonly ITripRepository _tripRepository;

        public TripService(ITripRepository tripRepository)
        {
            _tripRepository = tripRepository;
        }

        public async Task AddTripAsync(AddTripRequest trip)
        {
            if (trip.Validate() is false)
                throw new Exception("falha");

            Trip entity = new()
            {
                TripDescription = trip.TripName!,
                Id = trip.Id,
                TripName = trip.TripName!
            };

            await _tripRepository.AddAsync(entity);
        }

        public async Task DeleteTripAsync(int id)
        {
            await _tripRepository.DeleteAsync(id);
        }

        public async Task<IEnumerable<Trip>> GetAllTripsAsync()
        {
            return await _tripRepository.GetAllAsync();
        }

        public async Task<Trip> GetTripByIdAsync(int id)
        {
            return await _tripRepository.GetByIdAsync(id);
        }

        public async Task UpdateTripAsync(Trip trip)
        {
            await _tripRepository.UpdateAsync(trip);
        }
    }
}
