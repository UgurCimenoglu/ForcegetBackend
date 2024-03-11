using Forceget.Business.Abstract;
using Forceget.Entities.Dtos;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Forceget.WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [Authorize]
    public class OfferController : ControllerBase
    {
        private readonly IOfferService _offerService;

        public OfferController(IOfferService offerService)
        {
            _offerService = offerService;
        }

        [HttpGet]
        public IActionResult GetAll()
        {
            var res = _offerService.GetAll();
            return Ok(res);
        }

        [HttpPost]
        public async Task<IActionResult> AddAsync([FromBody] OfferAddDto data)
        {
            var res = await _offerService.AddAsync(data);
            if (res.Success) return Ok(res);
            return BadRequest(res);
        }
    }
}
