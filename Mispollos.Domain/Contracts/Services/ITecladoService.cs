using Mispollos.Domain.Entities;
using Mispollos.Domain.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Mispollos.Domain.Contracts.Services
{
    public interface ITecladoService
    {
        Task<List<Teclado>> GetTeclados();

        Task<Teclado> GetTecladoById(Guid id);

        Task<PagedResult<Teclado>> GetTecladosPaged(int page, string search);

        Task<Teclado> CreateTeclado(Teclado teclado);

        Task UpdateTeclado(Teclado teclado);

        Task DeleteTeclado(Guid id);
    }
}
