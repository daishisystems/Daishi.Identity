#region Includes

using System.Collections.Generic;
using Thinktecture.IdentityServer.Core.Models;

#endregion

namespace Daishi.Identity.SampleApp {
    public class Scopes {
        public static IEnumerable<Scope> Get() {
            var scopes = new List<Scope> {
                new Scope {
                    Enabled = true,
                    Name = "roles",
                    Type = ScopeType.Identity,
                    Claims = new List<ScopeClaim> {
                        new ScopeClaim("role")
                    }
                }
            };

            scopes.AddRange(StandardScopes.All);

            return scopes;
        }
    }
}