using Microsoft.EntityFrameworkCore;
using IdentityServer.EntityFramework.Entities;

namespace IdentityServer.EntityFramework.Interfaces
{
    public interface IAdminLogDbContext
    {
        DbSet<Log> Logs { get; set; }
    }
}
