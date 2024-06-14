using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Testing_MongoDB.Domain.DTOs;
using Testing_MongoDB.Services;

namespace Testing_MongoDB.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BrandsController : ControllerBase
    {
        private readonly IBrandService _brandService;
        public BrandsController(IBrandService brandService)
        {
            _brandService = brandService;
        }


        [HttpPost("CreateBrand")]
        public async Task<IActionResult> CreateBrand(CreateBrandDTO dto,CancellationToken cancellation=default)
        {
            if (!ModelState.IsValid) return BadRequest(ModelState);
            await _brandService.CreateBrandAsync(dto,cancellation);
            return Created();
        }
    }
}
