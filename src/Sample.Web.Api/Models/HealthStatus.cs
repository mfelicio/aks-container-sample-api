using Microsoft.AspNetCore.Mvc;

namespace Sample.Web.Api.Models
{
    public class HealthStatus
    {
        public string Version
        {
            get
            {
                return typeof(RuntimeEnvironment)
                        .GetTypeInfo().Assembly
                        .GetCustomAttribute<AssemblyFileVersionAttribute>()
                        .Version;
            }
        }
    }
}