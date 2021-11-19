using Model.Entities;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Repository.Interface
{
    public interface IBrandRepo
    {
        IQueryable<Brand> Brands { get; }
        Task<List<Brand>> GetListAsync();
        Task<Brand> GetByIdAsync(int brandId);
        Task<int> InsertAsync(Brand brand);
        Task UpdateAsync(Brand brand);
        Task DeleteAsync(Brand brand);
    }
}
