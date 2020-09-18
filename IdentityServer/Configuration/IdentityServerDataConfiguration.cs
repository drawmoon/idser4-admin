using System.Collections.Generic;
using IdentityServer4.Models;
using Client = IdentityServer.Configuration.IdentityServer.Client;

namespace IdentityServer.Configuration
{
    public class IdentityServerDataConfiguration
    {
        public List<Client> Clients { get; set; } = new List<Client>();
        public List<IdentityResource> IdentityResources { get; set; } = new List<IdentityResource>();
        public List<ApiResource> ApiResources { get; set; } = new List<ApiResource>();
    }
}
