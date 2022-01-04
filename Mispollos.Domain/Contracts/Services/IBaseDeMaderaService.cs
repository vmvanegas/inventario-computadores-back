using Mispollos.Domain.Entities;
using Mispollos.Domain.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Mispollos.Domain.Contracts.Services
{
    public interface IBaseDeMaderaService
    {
        Task<List<BaseDeMadera>> GetBasesDeMadera();

        Task<BaseDeMadera> GetBaseDeMaderaById(Guid id);

        Task<PagedResult<BaseDeMadera>> GetBasesDeMaderaPaged(int page, string search);

        Task<BaseDeMadera> CreateBaseDeMadera(BaseDeMadera baseDeMadera);

        Task UpdateBaseDeMadera(BaseDeMadera baseDeMadera);

        Task DeleteBaseDeMadera(Guid id);
    }
}
