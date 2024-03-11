using Forceget.Business.Abstract;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Forceget.WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [Authorize]
    public class Unit1Controller : ControllerBase
    {
        private readonly IUnit1Service _unit1;

        public Unit1Controller(IUnit1Service unit1)
        {
            _unit1 = unit1;
        }

        [HttpGet]
        public IActionResult GetAll()
        {
            var result = _unit1.GetAll();
            return Ok(result);
        }
    }
}
