using Application.v1.Interfaces;
using Application.v1.ViewModels.Requests.Trips;
using Application.v1.ViewModels.Responses.Trips;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;

namespace Api.Controllers.v1
{
    [Route("api/trip/")]
    [ApiController]
    public class TripManagmentController(ITripService tripService, IMapper mapper) : ControllerBase
    {
        private readonly ITripService _tripService = tripService;
        private readonly IMapper _mapper = mapper;

        [HttpGet("GetAll")]
        public async Task<IActionResult> GetAll()
        {
            return Ok(_mapper.Map<TripListResponse>(await _tripService.GetAllTripsAsync()));
        }

        [HttpGet("GetTrip/{id}")]
        public async Task<IActionResult> GetTripById(Guid id)
        {
            return Ok(_mapper.Map<TripResponse>(await _tripService.GetTripByIdAsync(id)));
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

        [HttpPut("UpdateTrip")]
        public async Task<IActionResult> Update(UpdateTripRequest request)
        {
            try
            {
                await _tripService.UpdateTripAsync(request);
                return Ok();
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }


        [HttpDelete("DeleteTrip/{id}")]
        public async Task<IActionResult> Delete(Guid id)
        {
            try
            {
                await _tripService.DeleteTripAsync(id);
                return Ok();
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }


    }
}
