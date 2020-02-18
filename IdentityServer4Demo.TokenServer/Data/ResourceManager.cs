using IdentityServer4.Models;
using System.Collections.Generic;

namespace IdentityServer4Demo.TokenServer.Data
{
    internal static class ResourceManager
    {
        public static IEnumerable<ApiResource> Apis =>
            new List<ApiResource>
            {
                new ApiResource {
                    Name = "app.api.whatever",
                    DisplayName = "Whatever Apis",
                    ApiSecrets = { new Secret("a75a559d-1dab-4c65-9bc0-f8e590cb388d".Sha256()) },
                    Scopes = new List<Scope> {
                        new Scope("app.api.whatever.read"),
                        new Scope("app.api.whatever.write"),
                        new Scope("app.api.whatever.full")
                    }
                },
                new ApiResource("app.api.weather","Weather Apis")
            };
    }
}
