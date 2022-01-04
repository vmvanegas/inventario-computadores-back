using Mispollos.Domain.Entities;
using Mispollos.Domain.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Mispollos.Domain.Contracts.Services
{
    public interface ICargadorService
    {
        Task<List<Cargador>> GetCargadores();

        Task<Cargador> GetCargadorById(Guid id);

        Task<PagedResult<Cargador>> GetCargadoresPaged(int page, string search);

        Task<Cargador> CreateCargador(Cargador cargador);

        Task UpdateCargador(Cargador cargador);

        Task DeleteCargador(Guid id);
    }
}
