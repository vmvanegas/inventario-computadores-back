using Mispollos.Domain.Entities;
using Mispollos.Domain.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Mispollos.Domain.Contracts.Services
{
    public interface IMonitorService
    {
        Task<List<Monitor>> GetMonitors();

        Task<Monitor> GetMonitorById(Guid id);

        Task<PagedResult<Monitor>> GetMonitorsPaged(int page, string search);

        Task<Monitor> CreateMonitor(Monitor monitor);

        Task UpdateMonitor(Monitor monitor);

        Task DeleteMonitor(Guid id);
    }
}
