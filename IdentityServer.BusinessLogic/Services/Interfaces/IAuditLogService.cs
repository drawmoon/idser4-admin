using System;
using System.Threading.Tasks;
using IdentityServer.BusinessLogic.Dtos.Log;

namespace IdentityServer.BusinessLogic.Services.Interfaces
{
    public interface IAuditLogService
    {
        Task<AuditLogsDto> GetAsync(AuditLogFilterDto filters);

        Task DeleteLogsOlderThanAsync(DateTime deleteOlderThan);
    }
}
