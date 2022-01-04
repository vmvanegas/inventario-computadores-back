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
    public class CargadorService : ICargadorService
    {
        private readonly IAsyncRepository<Cargador> _cargadorRepository;

        public CargadorService(IAsyncRepository<Cargador> cargadorRepository)
        {
            _cargadorRepository = cargadorRepository;
        }

        public async Task<List<Cargador>> GetCargadores()
        {
            return (await _cargadorRepository.ListAllAsync()).OrderBy(x => x.UpdatedOn).ToList();
        }

        public async Task<PagedResult<Cargador>> GetCargadoresPaged(int page, string search)
        {
            var result = new PagedResult<Cargador>();
            if (!string.IsNullOrEmpty(search))
            {
                result.Data = _cargadorRepository
                    .Query(x => x.Responsable.Contains(search))
                    .OrderByDescending(x => x.UpdatedOn)
                    .Skip((page - 1) * 10)
                    .Take(10)
                    .ToList();

                result.Total = await _cargadorRepository.CountByQuery(x => x.Responsable.Contains(search));
            }
            else
            {
                result.Data = (await _cargadorRepository
                    .ListAllAsync())
                    .OrderByDescending(x => x.UpdatedOn)
                    .Skip((page - 1) * 10)
                    .Take(10)
                    .ToList();

                result.Total = await _cargadorRepository.Count();
            }

            return result;
        }

        public async Task<Cargador> GetCargadorById(Guid id)
        {
            return await _cargadorRepository.GetByIdAsync(id);
        }

        public async Task<Cargador> CreateCargador(Cargador cargador)
        {
            cargador.CreatedOn = DateTime.Now;
            return await _cargadorRepository.AddAsync(cargador);
        }

        public async Task UpdateCargador(Cargador cargador)
        {
            await _cargadorRepository.UpdateAsync(cargador);
        }

        public async Task DeleteCargador(Guid id)
        {
            await _cargadorRepository.DeleteAsync(id);
        }
    }
}