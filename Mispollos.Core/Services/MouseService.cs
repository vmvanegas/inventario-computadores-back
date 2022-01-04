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
    public class MouseService : IMouseService
    {
        private readonly IAsyncRepository<Mouse> _mouseRepository;

        public MouseService(IAsyncRepository<Mouse> mouseRepository)
        {
            _mouseRepository = mouseRepository;
        }

        public async Task<List<Mouse>> GetMouses()
        {
            return (await _mouseRepository.ListAllAsync()).OrderBy(x => x.UpdatedOn).ToList();
        }

        public async Task<PagedResult<Mouse>> GetMousesPaged(int page, string search)
        {
            var result = new PagedResult<Mouse>();
            if (!string.IsNullOrEmpty(search))
            {
                result.Data = _mouseRepository
                    .Query(x => x.Responsable.Contains(search))
                    .OrderByDescending(x => x.UpdatedOn)
                    .Skip((page - 1) * 10)
                    .Take(10)
                    .ToList();

                result.Total = await _mouseRepository.CountByQuery(x => x.Responsable.Contains(search));
            }
            else
            {
                result.Data = (await _mouseRepository
                    .ListAllAsync())
                    .OrderByDescending(x => x.UpdatedOn)
                    .Skip((page - 1) * 10)
                    .Take(10)
                    .ToList();

                result.Total = await _mouseRepository.Count();
            }

            return result;
        }

        public async Task<Mouse> GetMouseById(Guid id)
        {
            return await _mouseRepository.GetByIdAsync(id);
        }

        public async Task<Mouse> CreateMouse(Mouse mouse)
        {
            mouse.CreatedOn = DateTime.Now;
            return await _mouseRepository.AddAsync(mouse);
        }

        public async Task UpdateMouse(Mouse mouse)
        {
            await _mouseRepository.UpdateAsync(mouse);
        }

        public async Task DeleteMouse(Guid id)
        {
            await _mouseRepository.DeleteAsync(id);
        }
    }
}