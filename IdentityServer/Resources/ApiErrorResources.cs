using IdentityServer.ExceptionHandling;
using Skoruba.IdentityServer4.Admin.Api.Resources;

namespace IdentityServer.Resources
{
    public class ApiErrorResources : IApiErrorResources
    {
        public virtual ApiError CannotSetId()
        {
            return new ApiError
            {
                Code = nameof(CannotSetId),
                Description = ApiErrorResource.CannotSetId
            };
        }
    }
}