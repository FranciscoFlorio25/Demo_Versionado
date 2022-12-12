using ALG_Demo_fflorio_SemVer.Model;
using Microsoft.Extensions.Options;

namespace ALG_Demo_fflorio_SemVer.Configuration
{
    public class AppVersionConfiguration
    {
        private readonly AppVersion _version;

        public AppVersionConfiguration(IOptions<AppVersion> version)
        {
            _version = version.Value;
        }

        public string GetVersion()
        {
            return "Version: " + _version.Version;
        }
    }
}
