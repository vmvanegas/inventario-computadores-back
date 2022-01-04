using Mispollos.Domain.Contracts.Repositories;
using Mispollos.Domain.Contracts.Services;
using Mispollos.Domain.Entities;
using Mispollos.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mispollos.Application.Services
{
    public class MonitorService : IMonitorService
    {
        private readonly IAsyncRepository<Monitor> _monitorRepository;

        public MonitorService(IAsyncRepository<Monitor> monitorRepository)
        {
            _monitorRepository = monitorRepository;
        }

        public async Task<List<Monitor>> GetMonitors()
        {
            return (await _monitorRepository.ListAllAsync()).OrderBy(x => x.UpdatedOn).ToList();
        }

        public async Task<PagedResult<Monitor>> GetMonitorsPaged(int page, string search)
        {
            var result = new PagedResult<Monitor>();
            if (!string.IsNullOrEmpty(search))
            {
                result.Data = _monitorRepository
                    .Query(x => x.Responsable.Contains(search))
                    .OrderByDescending(x => x.UpdatedOn)
                    .Skip((page - 1) * 10)
                    .Take(10)
                    .ToList();

                result.Total = await _monitorRepository.CountByQuery(x => x.Responsable.Contains(search));
            }
            else
            {
                result.Data = (await _monitorRepository
                    .ListAllAsync())
                    .OrderByDescending(x => x.UpdatedOn)
                    .Skip((page - 1) * 10)
                    .Take(10)
                    .ToList();

                result.Total = await _monitorRepository.Count();
            }

            return result;
        }

        public async Task<Monitor> GetMonitorById(Guid id)
        {
            return await _monitorRepository.GetByIdAsync(id);
        }

        public async Task<Monitor> CreateMonitor(Monitor monitor)
        {
            monitor.CreatedOn = DateTime.Now;
            return await _monitorRepository.AddAsync(monitor);
        }

        public async Task UpdateMonitor(Monitor monitor)
        {
            await _monitorRepository.UpdateAsync(monitor);
        }

        public async Task DeleteMonitor(Guid id)
        {
            await _monitorRepository.DeleteAsync(id);
        }
    }
}