using System;
using System.Threading.Tasks;
using IdentityServer.EntityFramework.Entities;
using IdentityServer.EntityFramework.Extensions.Common;

namespace IdentityServer.EntityFramework.Repositories.Interfaces
{
    public interface ILogRepository
    {
        Task<PagedList<Log>> GetLogsAsync(string search, int page = 1, int pageSize = 10);

        Task DeleteLogsOlderThanAsync(DateTime deleteOlderThan);
    }
}