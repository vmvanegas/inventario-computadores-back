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
    public class BaseDeMaderaService : IBaseDeMaderaService
    {
        private readonly IAsyncRepository<BaseDeMadera> _baseDeMaderaRepository;

        public BaseDeMaderaService(IAsyncRepository<BaseDeMadera> baseDeMaderaRepository)
        {
            _baseDeMaderaRepository = baseDeMaderaRepository;
        }

        public async Task<List<BaseDeMadera>> GetBasesDeMadera()
        {
            return (await _baseDeMaderaRepository.ListAllAsync()).OrderBy(x => x.UpdatedOn).ToList();
        }

        public async Task<PagedResult<BaseDeMadera>> GetBasesDeMaderaPaged(int page, string search)
        {
            var result = new PagedResult<BaseDeMadera>();
            if (!string.IsNullOrEmpty(search))
            {
                result.Data = _baseDeMaderaRepository
                    .Query(x => x.Responsable.Contains(search))
                    .OrderByDescending(x => x.UpdatedOn)
                    .Skip((page - 1) * 10)
                    .Take(10)
                    .ToList();

                result.Total = await _baseDeMaderaRepository.CountByQuery(x => x.Responsable.Contains(search));
            }
            else
            {
                result.Data = (await _baseDeMaderaRepository
                    .ListAllAsync())
                    .OrderByDescending(x => x.UpdatedOn)
                    .Skip((page - 1) * 10)
                    .Take(10)
                    .ToList();

                result.Total = await _baseDeMaderaRepository.Count();
            }

            return result;
        }

        public async Task<BaseDeMadera> GetBaseDeMaderaById(Guid id)
        {
            return await _baseDeMaderaRepository.GetByIdAsync(id);
        }

        public async Task<BaseDeMadera> CreateBaseDeMadera(BaseDeMadera baseDeMadera)
        {
            baseDeMadera.CreatedOn = DateTime.Now;
            return await _baseDeMaderaRepository.AddAsync(baseDeMadera);
        }

        public async Task UpdateBaseDeMadera(BaseDeMadera baseDeMadera)
        {
            await _baseDeMaderaRepository.UpdateAsync(baseDeMadera);
        }

        public async Task DeleteBaseDeMadera(Guid id)
        {
            await _baseDeMaderaRepository.DeleteAsync(id);
        }
    }
}