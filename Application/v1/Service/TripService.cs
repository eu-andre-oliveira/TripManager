using Application.v1.Interfaces;
using Application.v1.ViewModels.Requests.Trips;
using AutoMapper;
using Core.v1.Entities;
using Core.v1.Interfaces;

namespace Application.v1.Service
{
    public class TripService(ITripRepository tripRepository, IMapper mapper) : ITripService
    {
        private readonly ITripRepository _tripRepository = tripRepository;
        private readonly IMapper _mapper = mapper;

        public async Task AddTripAsync(AddTripRequest trip)
        {
            if (trip.Validate() is false)
                throw new Exception(string.Join(Environment.NewLine, trip.ValidationErrors!));

            Trip entity = _mapper.Map<Trip>(trip);

            await _tripRepository.AddAsync(entity);
        }

        public async Task DeleteTripAsync(Guid id)
        {
            await _tripRepository.DeleteAsync(id);
        }

        public async Task<IEnumerable<Trip>> GetAllTripsAsync()
        {
            return await _tripRepository.GetAllAsync();
        }

        public async Task<Trip?> GetTripByIdAsync(Guid id)
        {
            return await _tripRepository.GetByIdAsync(id);
        }

        public async Task UpdateTripAsync(UpdateTripRequest trip)
        {
            if (trip.Validate() is false)
                throw new Exception(string.Join(Environment.NewLine, trip.ValidationErrors!));

            await _tripRepository.UpdateAsync(_mapper.Map<Trip>(trip));
        }
    }
}
