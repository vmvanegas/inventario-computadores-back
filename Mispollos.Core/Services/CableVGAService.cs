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
    public class CableVGAService : ICableVGAService
    {
        private readonly IAsyncRepository<CableVGA> _cableVGARepository;

        public CableVGAService(IAsyncRepository<CableVGA> cableVGARepository)
        {
            _cableVGARepository = cableVGARepository;
        }

        public async Task<List<CableVGA>> GetCablesVGA()
        {
            return (await _cableVGARepository.ListAllAsync()).OrderBy(x => x.UpdatedOn).ToList();
        }

        public async Task<PagedResult<CableVGA>> GetCablesVGAPaged(int page, string search)
        {
            var result = new PagedResult<CableVGA>();
            if (!string.IsNullOrEmpty(search))
            {
                result.Data = _cableVGARepository
                    .Query(x => x.Responsable.Contains(search))
                    .OrderByDescending(x => x.UpdatedOn)
                    .Skip((page - 1) * 10)
                    .Take(10)
                    .ToList();

                result.Total = await _cableVGARepository.CountByQuery(x => x.Responsable.Contains(search));
            }
            else
            {
                result.Data = (await _cableVGARepository
                    .ListAllAsync())
                    .OrderByDescending(x => x.UpdatedOn)
                    .Skip((page - 1) * 10)
                    .Take(10)
                    .ToList();

                result.Total = await _cableVGARepository.Count();
            }

            return result;
        }

        public async Task<CableVGA> GetCableVGAById(Guid id)
        {
            return await _cableVGARepository.GetByIdAsync(id);
        }

        public async Task<CableVGA> CreateCableVGA(CableVGA cableVGA)
        {
            cableVGA.CreatedOn = DateTime.Now;
            return await _cableVGARepository.AddAsync(cableVGA);
        }

        public async Task UpdateCableVGA(CableVGA cableVGA)
        {
            await _cableVGARepository.UpdateAsync(cableVGA);
        }

        public async Task DeleteCableVGA(Guid id)
        {
            await _cableVGARepository.DeleteAsync(id);
        }
    }
}