using Mispollos.Domain.Entities;
using Mispollos.Domain.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Mispollos.Domain.Contracts.Services
{
    public interface IMouseService
    {
        Task<List<Mouse>> GetMouses();

        Task<Mouse> GetMouseById(Guid id);

        Task<PagedResult<Mouse>> GetMousesPaged(int page, string search);

        Task<Mouse> CreateMouse(Mouse mouse);

        Task UpdateMouse(Mouse mouse);

        Task DeleteMouse(Guid id);
    }
}
