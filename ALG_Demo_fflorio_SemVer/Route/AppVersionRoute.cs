using System;

namespace ALG_Demo_fflorio_SemVer.Route
{
    public static class AppVersionRoute
    {
        public static IEndpointRouteBuilder MapVersions(this IEndpointRouteBuilder builder)
        {
            builder.MapGet("/appVersion", () =>
            {
                var AppVersion = new ConfigurationBuilder().AddJsonFile("appsettings.json").Build().GetSection("AppVersion")["Version"];
                
                return AppVersion;
            })
            .WithName("GetVersion");

            return builder;
        }
    }
}
