using Model.Entities;
using Repository.Interface;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Repository.Implementation
{
    public class BrandRepo : IBrandRepo
    {
        private readonly IRepositoryAsync<Brand> _repository;

        public BrandRepo(IRepositoryAsync<Brand> repository)
        {
            _repository = repository;
        }

        public IQueryable<Brand> Brands => _repository.Entities;

        public async Task DeleteAsync(Brand brand)
        {
            await _repository.DeleteAsync(brand);
        }

        public async Task<Brand> GetByIdAsync(int brandId)
        {
            return await _repository.GetByIdAsync(brandId);
        }

        public async Task<List<Brand>> GetListAsync()
        {
            return await _repository.GetAllAsync();
        }

        public async Task<int> InsertAsync(Brand brand)
        {
            await _repository.AddAsync(brand);
            return brand.Id;
        }

        public async Task UpdateAsync(Brand brand)
        {
            await _repository.UpdateAsync(brand);
        }
    }
}
