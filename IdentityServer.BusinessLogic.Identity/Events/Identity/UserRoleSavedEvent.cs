using Skoruba.AuditLogging.Events;

namespace IdentityServer.BusinessLogic.Identity.Events.Identity
{
    public class UserRoleSavedEvent<TUserRolesDto> : AuditEvent
    {
        public TUserRolesDto Role { get; set; }

        public UserRoleSavedEvent(TUserRolesDto role)
        {
            Role = role;
        }
    }
}