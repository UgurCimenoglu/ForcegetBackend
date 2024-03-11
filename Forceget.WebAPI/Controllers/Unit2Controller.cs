using Forceget.Business.Abstract;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Forceget.WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [Authorize]
    public class Unit2Controller : ControllerBase
    {
        private readonly IUnit2Service _unit2;

        public Unit2Controller(IUnit2Service unit2)
        {
            _unit2 = unit2;
        }

        [HttpGet]
        public IActionResult GetAll()
        {
            var result = _unit2.GetAll();
            return Ok(result);
        }
    }
}
