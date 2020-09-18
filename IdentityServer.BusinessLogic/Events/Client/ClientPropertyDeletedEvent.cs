using Skoruba.AuditLogging.Events;
using IdentityServer.BusinessLogic.Dtos.Configuration;

namespace IdentityServer.BusinessLogic.Events.Client
{
    public class ClientPropertyDeletedEvent : AuditEvent
    {
        public ClientPropertiesDto ClientProperty { get; set; }

        public ClientPropertyDeletedEvent(ClientPropertiesDto clientProperty)
        {
            ClientProperty = clientProperty;
        }
    }
}