using Skoruba.AuditLogging.Events;

namespace IdentityServer.BusinessLogic.Identity.Events.Identity
{
    public class UserProvidersRequestedEvent<TUserProvidersDto> : AuditEvent
    {
        public TUserProvidersDto Providers { get; set; }

        public UserProvidersRequestedEvent(TUserProvidersDto providers)
        {
            Providers = providers;
        }
    }
}