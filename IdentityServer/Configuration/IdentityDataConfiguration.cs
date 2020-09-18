using System.Collections.Generic;
using IdentityServer.Configuration.Identity;

namespace IdentityServer.Configuration
{
    public class IdentityDataConfiguration
    {
       public List<Role> Roles { get; set; }
       public List<User> Users { get; set; }
    }
}
