using System;

namespace ALG_Demo_fflorio_SemVer.Route
{
    public static class AppVersionRoute
    {
        public static IEndpointRouteBuilder MapVersions(this IEndpointRouteBuilder builder)
        {
            builder.MapGet("/appVersion", () =>
            {
                
                var appVersion = new ConfigurationBuilder().AddJsonFile("appsettings.json").Build().GetSection("AppVersion")["Version"];
                var version = "AppVersion " + appVersion;
                return version;
            })
            .WithName("GetVersion");

            return builder;
        }
    }
}
