using Model.Entities;
using Repository.Interface;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Repository.Implementation
{
    public class ProductRepo : IProductRepo
    {
        private readonly IRepositoryAsync<Product> _repository;

        public ProductRepo(IRepositoryAsync<Product> repository)
        {
            _repository = repository;
        }

        public IQueryable<Product> Products => _repository.Entities;

        public async Task DeleteAsync(Product product)
        {
            await _repository.DeleteAsync(product);
            await _repository.SaveAsync();
        }

        public async Task<Product> GetByIdAsync(int productId)
        {
            return await _repository.GetByIdAsync(productId);
        }

        public async Task<List<Product>> GetListAsync()
        {
            return await _repository.GetAllAsync();
        }

        public async Task<int> InsertAsync(Product product)
        {
            await _repository.AddAsync(product);
            await _repository.SaveAsync();
            return product.Id;
        }

        public async Task UpdateAsync(Product product)
        {
            await _repository.UpdateAsync(product);
            await _repository.SaveAsync();
        }
    }
}
