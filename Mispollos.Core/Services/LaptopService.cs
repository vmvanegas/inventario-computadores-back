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
    public class LaptopService : ILaptopService
    {
        private readonly IAsyncRepository<Laptop> _laptopRepository;

        public LaptopService(IAsyncRepository<Laptop> laptopRepository)
        {
            _laptopRepository = laptopRepository;
        }

        public async Task<List<Laptop>> GetLaptops()
        {
            return (await _laptopRepository.ListAllAsync()).OrderBy(x => x.UpdatedOn).ToList();
        }

        public async Task<PagedResult<Laptop>> GetLaptopsPaged(int page, string search)
        {
            var result = new PagedResult<Laptop>();
            if (!string.IsNullOrEmpty(search))
            {
                result.Data = _laptopRepository
                    .Query(x => x.Responsable.Contains(search))
                    .OrderByDescending(x => x.UpdatedOn)
                    .Skip((page - 1) * 10)
                    .Take(10)
                    .ToList();

                result.Total = await _laptopRepository.CountByQuery(x => x.Responsable.Contains(search));
            }
            else
            {
                result.Data = (await _laptopRepository
                    .ListAllAsync())
                    .OrderByDescending(x => x.UpdatedOn)
                    .Skip((page - 1) * 10)
                    .Take(10)
                    .ToList();

                result.Total = await _laptopRepository.Count();
            }

            return result;
        }

        public async Task<Laptop> GetLaptopById(Guid id)
        {
            return await _laptopRepository.GetByIdAsync(id);
        }

        public async Task<Laptop> CreateLaptop(Laptop laptop)
        {
            laptop.CreatedOn = DateTime.Now;
            return await _laptopRepository.AddAsync(laptop);
        }

        public async Task UpdateLaptop(Laptop laptop)
        {
            await _laptopRepository.UpdateAsync(laptop);
        }

        public async Task DeleteLaptop(Guid id)
        {
            await _laptopRepository.DeleteAsync(id);
        }
    }
}