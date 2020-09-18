using Skoruba.AuditLogging.Events;
using IdentityServer.BusinessLogic.Dtos.Configuration;

namespace IdentityServer.BusinessLogic.Events.ApiResource
{
    public class ApiResourcesRequestedEvent : AuditEvent
    {
        public ApiResourcesRequestedEvent(ApiResourcesDto apiResources)
        {
            ApiResources = apiResources;
        }

        public ApiResourcesDto ApiResources { get; set; }
    }
}