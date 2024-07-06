using Application.v1.ViewModels.Requests.Trips;
using Core.v1.Entities;

namespace Application.v1.Interfaces
{
    public interface ITripService
    {
        Task<IEnumerable<Trip>> GetAllTripsAsync();
        Task<Trip> GetTripByIdAsync(int id);
        Task AddTripAsync(AddTripRequest trip);
        Task UpdateTripAsync(Trip trip);
        Task DeleteTripAsync(int id);
    }
}
