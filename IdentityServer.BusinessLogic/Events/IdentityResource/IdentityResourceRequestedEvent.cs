using Skoruba.AuditLogging.Events;
using IdentityServer.BusinessLogic.Dtos.Configuration;

namespace IdentityServer.BusinessLogic.Events.IdentityResource
{
    public class IdentityResourceRequestedEvent : AuditEvent
    {
        public IdentityResourceDto IdentityResource { get; set; }

        public IdentityResourceRequestedEvent(IdentityResourceDto identityResource)
        {
            IdentityResource = identityResource;
        }
    }
}