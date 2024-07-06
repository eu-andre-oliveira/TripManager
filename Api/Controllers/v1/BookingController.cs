using Application.v1.Interfaces;
using Application.v1.ViewModels.Requests.Trips;
using Microsoft.AspNetCore.Mvc;

namespace Api.Controllers.v1
{
    [Route("api/booking/")]
    [ApiController]
    public class BookingController(ITripService tripService) : ControllerBase
    {
        private readonly ITripService _tripService = tripService;

        [HttpGet("GetAllTrips")]
        public async Task<IActionResult> GetAll()
        {
            return Ok(await _tripService.GetAllTripsAsync());
        }

        [HttpGet("GetTrip/{id}")]
        public async Task<IActionResult> GetTripById(int id)
        {
            return Ok(await _tripService.GetTripByIdAsync(id));
        }

        [HttpPost("AddTrip")]
        public async Task<IActionResult> Add(AddTripRequest request)
        {

            try
            {
                await _tripService.AddTripAsync(request);
                return Ok();
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

    


    }
}
