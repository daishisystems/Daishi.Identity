#region Includes

using System;
using System.Security.Cryptography.X509Certificates;
using Owin;
using Thinktecture.IdentityServer.Core.Configuration;
using Thinktecture.IdentityServer.Core.Models;

#endregion

namespace Daishi.Identity.SampleApp {
    public class Startup {
        public void Configuration(IAppBuilder app) {
            app.Map("/identity", idsrvApp => {
                idsrvApp.UseIdentityServer(new IdentityServerOptions {
                    SiteName = "Embedded IdentityServer",
                    SigningCertificate = LoadCertificate(),
                    Factory = InMemoryFactory.Create(
                        users: Users.Get(),
                        clients: Clients.Get(),
                        scopes: StandardScopes.All)
                });
            });
        }

        private X509Certificate2 LoadCertificate() {
            return new X509Certificate2(
                string.Format(@"{0}\bin\identityServer\idsrv3test.pfx", AppDomain.CurrentDomain.BaseDirectory), "idsrv3test");
        }
    }
}