using IdentityServer.BusinessLogic.Identity.Dtos.Identity.Base;
using IdentityServer.BusinessLogic.Identity.Dtos.Identity.Interfaces;

namespace IdentityServer.BusinessLogic.Identity.Dtos.Identity
{
    public class UserProviderDto<TUserDtoKey> : BaseUserProviderDto<TUserDtoKey>, IUserProviderDto
    {
        public string UserName { get; set; }

        public string ProviderKey { get; set; }

        public string LoginProvider { get; set; }

        public string ProviderDisplayName { get; set; }
    }
}
