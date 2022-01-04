using Mispollos.Domain.Entities;
using Mispollos.Domain.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Mispollos.Domain.Contracts.Services
{
    public interface IDiademaService
    {
        Task<List<Diadema>> GetDiademas();

        Task<Diadema> GetDiademaById(Guid id);

        Task<PagedResult<Diadema>> GetDiademasPaged(int page, string search);

        Task<Diadema> CreateDiadema(Diadema diadema);

        Task UpdateDiadema(Diadema diadema);

        Task DeleteDiadema(Guid id);
    }
}
