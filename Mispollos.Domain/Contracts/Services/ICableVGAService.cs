using Mispollos.Domain.Entities;
using Mispollos.Domain.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Mispollos.Domain.Contracts.Services
{
    public interface ICableVGAService
    {
        Task<List<CableVGA>> GetCablesVGA();

        Task<CableVGA> GetCableVGAById(Guid id);

        Task<PagedResult<CableVGA>> GetCablesVGAPaged(int page, string search);

        Task<CableVGA> CreateCableVGA(CableVGA cableVGA);

        Task UpdateCableVGA(CableVGA cableVGA);

        Task DeleteCableVGA(Guid id);
    }
}
