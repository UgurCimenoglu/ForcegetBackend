using Forceget.Business.Abstract;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Forceget.WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [Authorize]
    public class IncotermController : ControllerBase
    {
        private readonly IIncotermService _incotermService;

        public IncotermController(IIncotermService incotermService)
        {
            _incotermService = incotermService;
        }

        [HttpGet]
        public IActionResult Index()
        {
            var result = _incotermService.GetAll();
            return Ok(result);
        }
    }
}
