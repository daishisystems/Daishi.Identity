﻿#region Includes

using System.Collections.Generic;
using System.Security.Claims;
using Thinktecture.IdentityServer.Core;
using Thinktecture.IdentityServer.Core.Services.InMemory;

#endregion

namespace Daishi.Identity.SampleApp {
    public static class Users {
        public static List<InMemoryUser> Get() {
            return new List<InMemoryUser> {
                new InMemoryUser {
                    Username = "bob",
                    Password = "secret",
                    Subject = "1",
                    Claims = new[] {
                        new Claim(Constants.ClaimTypes.GivenName, "Bob"),
                        new Claim(Constants.ClaimTypes.FamilyName, "Smith")
                    }
                }
            };
        }
    }
}