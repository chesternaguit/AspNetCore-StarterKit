using Model.Entities;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Repository.Interface
{
    public interface IProductRepo
    {
        IQueryable<Product> Products { get; }
        Task<List<Product>> GetListAsync();
        Task<Product> GetByIdAsync(int productId);
        Task<int> InsertAsync(Product product);
        Task UpdateAsync(Product product);
        Task DeleteAsync(Product product);
    }
}
