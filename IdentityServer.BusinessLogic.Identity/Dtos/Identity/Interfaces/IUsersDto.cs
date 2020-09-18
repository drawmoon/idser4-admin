using System.Collections.Generic;

namespace IdentityServer.BusinessLogic.Identity.Dtos.Identity.Interfaces
{
    public interface IUsersDto
    {
        int PageSize { get; set; }
        int TotalCount { get; set; }
        List<IUserDto> Users { get; }
    }
}
