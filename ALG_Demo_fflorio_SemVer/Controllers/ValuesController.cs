using ALG_Demo_fflorio_SemVer.Configuration;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ALG_Demo_fflorio_SemVer.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ValuesController : ControllerBase
    {
        private readonly AppVersionConfiguration _configuration;

        public ValuesController(AppVersionConfiguration configuration)
        {
            _configuration = configuration;
        }

        [HttpGet(Name = "GetVersion")]
        public string GetVersion()
        {
            return _configuration.GetVersion();
        }
    }
}
