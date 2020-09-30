﻿using System;
using System.Threading.Tasks;
using Skoruba.AuditLogging.EntityFramework.Entities;
using IdentityServer.EntityFramework.Extensions.Common;

namespace IdentityServer.EntityFramework.Repositories.Interfaces
{
    public interface IAuditLogRepository<TAuditLog> where TAuditLog : AuditLog
    {
        Task<PagedList<TAuditLog>> GetAsync(string @event, string source, string category, DateTime? created, string subjectIdentifier, string subjectName, int page = 1, int pageSize = 10);

        Task DeleteLogsOlderThanAsync(DateTime deleteOlderThan);
    }
}