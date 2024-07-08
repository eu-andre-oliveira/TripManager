using Application.v1.Interfaces;
using Application.v1.ViewModels.Responses.Registrations;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Api.Controllers.v1
{
    [Route("api/booking/")]
    [ApiController]
    public class BookingController : ControllerBase
    {
        private readonly ITripRegistrationService _tripRegistrationService;
        private readonly IMapper _mapper;

        public BookingController( IMapper mapper, ITripRegistrationService tripRegistrationService)
        {
            _mapper = mapper;
            _tripRegistrationService = tripRegistrationService;
        }

        [HttpGet("GetAll")]
        public async Task<IActionResult> GetAsync()
        {
            return Ok(_mapper.Map<RegistrationsListResponse>(await _tripRegistrationService.GetAllAsync()));
        }


        [HttpGet("GetById/{id}")]
        public async Task<IActionResult> Get(Guid id)
        {
            return Ok(_mapper.Map<RegistrationResponse>(await _tripRegistrationService.GetAsync(id)));
        }


        [HttpPost("Add")]
        public async Task<IActionResult> Post([FromBody] string value)
        {
            return Ok();
        }


        [HttpPut("Update/{id}")]
        public async Task<IActionResult> Put(Guid id, [FromBody] string value)
        {
            return Ok();
        }


        [HttpDelete("Delete/{id}")]
        public async Task<IActionResult> Delete(Guid id)
        {
            return Ok();
        }
    }
}
