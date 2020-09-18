using Skoruba.AuditLogging.Events;
using IdentityServer.BusinessLogic.Identity.Dtos.Grant;

namespace IdentityServer.BusinessLogic.Identity.Events.PersistedGrant
{
    public class PersistedGrantsIdentityByUsersRequestedEvent : AuditEvent
    {
        public PersistedGrantsDto PersistedGrants { get; set; }

        public PersistedGrantsIdentityByUsersRequestedEvent(PersistedGrantsDto persistedGrants)
        {
            PersistedGrants = persistedGrants;
        }
    }
}