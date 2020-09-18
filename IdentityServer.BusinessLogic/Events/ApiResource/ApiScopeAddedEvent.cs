using Skoruba.AuditLogging.Events;
using IdentityServer.BusinessLogic.Dtos.Configuration;

namespace IdentityServer.BusinessLogic.Events.ApiResource
{
    public class ApiScopeAddedEvent : AuditEvent
    {
        public ApiScopesDto ApiScope { get; set; }

        public ApiScopeAddedEvent(ApiScopesDto apiScope)
        {
            ApiScope = apiScope;
        }
    }
}