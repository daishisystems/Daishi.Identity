﻿#region Includes

using System.Collections.Generic;
using Thinktecture.IdentityServer.Core.Models;

#endregion

namespace Daishi.Identity.SampleApp {
    public static class Clients {
        public static IEnumerable<Client> Get() {
            return new[] {
                new Client {
                    Enabled = true,
                    ClientName = "MVC Client",
                    ClientId = "mvc",
                    Flow = Flows.Implicit,
                    RedirectUris = new List<string> {
                        "https://localhost:44301/"
                    }
                }
            };
        }
    }
}