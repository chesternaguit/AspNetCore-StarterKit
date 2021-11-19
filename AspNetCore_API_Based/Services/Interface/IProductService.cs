using Model.Request;
using Model.Response;
using System;
using System.Threading.Tasks;

namespace Services.Interface
{
    public interface IProductService
    {
        Task<ServiceResponse> GetAll();
        Task<ServiceResponse> GetById(int id);
        Task<ServiceResponse> Create(ProductRequest reqObj);
        Task<ServiceResponse> Update(ProductRequest reqObj);
        Task<ServiceResponse> Delete(int id);
    }
}
