using Application.v1.ViewModels.Requests.Trips;
using Core.v1.Entities;

namespace Application.v1.Interfaces
{
    public interface ITripService
    {
        Task<IEnumerable<Trip>> GetAllTripsAsync();
        Task<Trip?> GetTripByIdAsync(Guid id);
        Task AddTripAsync(AddTripRequest trip);
        Task UpdateTripAsync(UpdateTripRequest trip);
        Task DeleteTripAsync(Guid id);
    }
}
