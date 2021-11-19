using Model.Entities;
using Model.Request;
using Model.Response;
using Repository.Interface;
using Services.Interface;
using System;
using System.Net;
using System.Threading.Tasks;

namespace Services.Implementation
{
    public class ProductService : IProductService
    {
        private readonly IProductRepo _IProductRepo;
        public ProductService(IProductRepo IProductRepo)
        {
            _IProductRepo = IProductRepo;
        }

        public async Task<ServiceResponse> Create(ProductRequest reqObj)
        {
            var objResponse = new ServiceResponse();
            try
            {
                if(reqObj != null)
                {
                    var newProduct = new Product()
                    {
                        Name = reqObj.Name,
                        Barcode = reqObj.Barcode,
                        Image = reqObj.Image,
                        Description = reqObj.Description,
                        Rate = reqObj.Rate,
                        BrandId = reqObj.BrandId
                    };
                    var productId = await _IProductRepo.InsertAsync(newProduct);

                    objResponse.result = await _IProductRepo.GetByIdAsync(productId);
                    objResponse.success = true;
                    objResponse.status = HttpStatusCode.OK;
                }
            }
            catch (Exception ex)
            {
                objResponse.message = ex.ToString();
                objResponse.success = false;
                objResponse.status = HttpStatusCode.InternalServerError;
            }
            return objResponse;
        }

        public Task<ServiceResponse> Delete(int id)
        {
            throw new NotImplementedException();
        }

        public async Task<ServiceResponse> GetAll()
        {
            var objResponse = new ServiceResponse();
            try
            {
                var list = await _IProductRepo.GetListAsync();

                objResponse.result = list;
                objResponse.success = true;
                objResponse.status = HttpStatusCode.OK;

            }
            catch (Exception ex)
            {
                objResponse.message = ex.ToString();
                objResponse.success = false;
                objResponse.status = HttpStatusCode.InternalServerError;
            }
            return objResponse;
        }

        public async Task<ServiceResponse> GetById(int productId)
        {
            var objResponse = new ServiceResponse();
            try
            {
                var product = await _IProductRepo.GetByIdAsync(productId);

                if (product != null)
                {
                    objResponse.result = product;
                    objResponse.success = true;
                    objResponse.status = HttpStatusCode.OK;
                }
                else
                {
                    objResponse.result = null;
                    objResponse.success = false;
                    objResponse.message = "Product Not Found!";
                    objResponse.status = HttpStatusCode.NotFound;
                }
            }
            catch (Exception ex)
            {
                objResponse.message = ex.ToString();
                objResponse.success = false;
                objResponse.status = HttpStatusCode.InternalServerError;
            }
            return objResponse;
        }

        public Task<ServiceResponse> Update(ProductRequest reqObj)
        {
            throw new NotImplementedException();
        }
    }
}
