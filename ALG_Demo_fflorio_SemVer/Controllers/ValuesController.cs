using ALG_Demo_fflorio_SemVer.DTO;
using ALG_Demo_fflorio_SemVer.Manager;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ALG_Demo_fflorio_SemVer.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ValuesController : ControllerBase
    {
        private readonly AppVersionManager _configuration;

        public ValuesController(AppVersionManager configuration)
        {
            _configuration = configuration;
        }

        [HttpGet(Name = "GetVersion")]
        public IActionResult GetVersion()
        {
            return Ok( new AppVersionDTO( _configuration.GetVersion()));
        }
    }
}
