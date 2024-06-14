using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Testing_MongoDB.Domain.DTOs;
using Testing_MongoDB.Services;

namespace Testing_MongoDB.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CarsController : ControllerBase
    {
        private readonly ICarService _carService;
        public CarsController(ICarService carService)
        {
            _carService = carService;
        }


        [HttpPost("CreateCar")]
        public async Task<IActionResult> CreateCar(CreateCarDTO dto, CancellationToken cancellation = default)
        {
            if (!ModelState.IsValid) return BadRequest(ModelState);
            var result = await _carService.CreateCar(dto, cancellation);
            if (!result) return NotFound("There is no Brand with this Id");
            return Created();
        }
    }
}
