using Forceget.Business.Abstract;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Forceget.WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [Authorize]
    public class MovementTypeController : ControllerBase
    {
        private readonly IMovementTypeService _movementTypeService;

        public MovementTypeController(IMovementTypeService movementTypeService)
        {
            _movementTypeService = movementTypeService;
        }

        [HttpGet]
        public IActionResult GetAll()
        {
            var result = _movementTypeService.GetAll();
            return Ok(result);
        }
    }
}
