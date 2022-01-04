using Mispollos.Domain.Entities;
using Mispollos.Domain.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Mispollos.Domain.Contracts.Services
{
    public interface ILaptopService
    {
        Task<List<Laptop>> GetLaptops();

        Task<Laptop> GetLaptopById(Guid id);

        Task<PagedResult<Laptop>> GetLaptopsPaged(int page, string search);

        Task<Laptop> CreateLaptop(Laptop laptops);

        Task UpdateLaptop(Laptop laptops);

        Task DeleteLaptop(Guid id);
    }
}
