using System.ComponentModel.DataAnnotations;
using IdentityServer.BusinessLogic.Identity.Dtos.Identity.Base;
using IdentityServer.BusinessLogic.Identity.Dtos.Identity.Interfaces;

namespace IdentityServer.BusinessLogic.Identity.Dtos.Identity
{
    public class RoleDto<TKey> : BaseRoleDto<TKey>, IRoleDto
    {      
        [Required]
        public string Name { get; set; }
    }
}