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
    public class TecladoService : ITecladoService
    {
        private readonly IAsyncRepository<Teclado> _tecladoRepository;

        public TecladoService(IAsyncRepository<Teclado> tecladoRepository)
        {
            _tecladoRepository = tecladoRepository;
        }

        public async Task<List<Teclado>> GetTeclados()
        {
            return (await _tecladoRepository.ListAllAsync()).OrderBy(x => x.UpdatedOn).ToList();
        }

        public async Task<PagedResult<Teclado>> GetTecladosPaged(int page, string search)
        {
            var result = new PagedResult<Teclado>();
            if (!string.IsNullOrEmpty(search))
            {
                result.Data = _tecladoRepository
                    .Query(x => x.Responsable.Contains(search))
                    .OrderByDescending(x => x.UpdatedOn)
                    .Skip((page - 1) * 10)
                    .Take(10)
                    .ToList();

                result.Total = await _tecladoRepository.CountByQuery(x => x.Responsable.Contains(search));
            }
            else
            {
                result.Data = (await _tecladoRepository
                    .ListAllAsync())
                    .OrderByDescending(x => x.UpdatedOn)
                    .Skip((page - 1) * 10)
                    .Take(10)
                    .ToList();

                result.Total = await _tecladoRepository.Count();
            }

            return result;
        }

        public async Task<Teclado> GetTecladoById(Guid id)
        {
            return await _tecladoRepository.GetByIdAsync(id);
        }

        public async Task<Teclado> CreateTeclado(Teclado teclado)
        {
            teclado.CreatedOn = DateTime.Now;
            return await _tecladoRepository.AddAsync(teclado);
        }

        public async Task UpdateTeclado(Teclado teclado)
        {
            await _tecladoRepository.UpdateAsync(teclado);
        }

        public async Task DeleteTeclado(Guid id)
        {
            await _tecladoRepository.DeleteAsync(id);
        }
    }
}