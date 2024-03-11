using Forceget.Business.Abstract;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Forceget.WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [Authorize]
    public class ModeController : ControllerBase
    {
        private readonly IModeService _modeService;

        public ModeController(IModeService modeService)
        {
            _modeService = modeService;
        }

        [HttpGet]
        public IActionResult GetAll()
        {
            var result = _modeService.GetAll();
            return Ok(result);
        }
    }
}
