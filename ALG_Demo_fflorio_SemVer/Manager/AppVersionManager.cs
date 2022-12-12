using ALG_Demo_fflorio_SemVer.Model;
using Microsoft.Extensions.Options;

namespace ALG_Demo_fflorio_SemVer.Manager

{
    public class AppVersionManager
    {
        private readonly AppVersion _version;

        public AppVersionManager(IOptions<AppVersion> version)
        {
            _version = version.Value;
        }

        public string GetVersion()
        {
            return _version.Version;
        }
    }
}
