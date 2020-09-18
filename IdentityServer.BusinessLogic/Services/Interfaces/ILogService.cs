using System;
using System.Threading.Tasks;
using IdentityServer.BusinessLogic.Dtos.Log;

namespace IdentityServer.BusinessLogic.Services.Interfaces
{
    public interface ILogService
    {
        Task<LogsDto> GetLogsAsync(string search, int page = 1, int pageSize = 10);

        Task DeleteLogsOlderThanAsync(DateTime deleteOlderThan);
    }
}