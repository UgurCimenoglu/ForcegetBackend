using Forceget.Business.Abstract;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Forceget.WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [Authorize]
    public class PackageTypeController : ControllerBase
    {
        private readonly IPackageTypeService _packageTypeService;

        public PackageTypeController(IPackageTypeService packageTypeService)
        {
            _packageTypeService = packageTypeService;
        }

        [HttpGet]
        public IActionResult GetAll()
        {
            var result = _packageTypeService.GetAll();
            return Ok(result);
        }
    }
}
