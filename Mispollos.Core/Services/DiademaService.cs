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
    public class DiademaService : IDiademaService
    {
        private readonly IAsyncRepository<Diadema> _diademaRepository;

        public DiademaService(IAsyncRepository<Diadema> diademaRepository)
        {
            _diademaRepository = diademaRepository;
        }

        public async Task<List<Diadema>> GetDiademas()
        {
            return (await _diademaRepository.ListAllAsync()).OrderBy(x => x.UpdatedOn).ToList();
        }

        public async Task<PagedResult<Diadema>> GetDiademasPaged(int page, string search)
        {
            var result = new PagedResult<Diadema>();
            if (!string.IsNullOrEmpty(search))
            {
                result.Data = _diademaRepository
                    .Query(x => x.Responsable.Contains(search))
                    .OrderByDescending(x => x.UpdatedOn)
                    .Skip((page - 1) * 10)
                    .Take(10)
                    .ToList();

                result.Total = await _diademaRepository.CountByQuery(x => x.Responsable.Contains(search));
            }
            else
            {
                result.Data = (await _diademaRepository
                    .ListAllAsync())
                    .OrderByDescending(x => x.UpdatedOn)
                    .Skip((page - 1) * 10)
                    .Take(10)
                    .ToList();

                result.Total = await _diademaRepository.Count();
            }

            return result;
        }

        public async Task<Diadema> GetDiademaById(Guid id)
        {
            return await _diademaRepository.GetByIdAsync(id);
        }

        public async Task<Diadema> CreateDiadema(Diadema diadema)
        {
            diadema.CreatedOn = DateTime.Now;
            return await _diademaRepository.AddAsync(diadema);
        }

        public async Task UpdateDiadema(Diadema diadema)
        {
            await _diademaRepository.UpdateAsync(diadema);
        }

        public async Task DeleteDiadema(Guid id)
        {
            await _diademaRepository.DeleteAsync(id);
        }
    }
}