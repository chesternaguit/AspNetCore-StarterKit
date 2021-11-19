using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Model.Request;
using Services.Interface;

namespace API.Controllers.Client
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        IProductService _IProductService;
        public ProductController(IProductService IProductService)
        {
            _IProductService = IProductService;
        }

        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            var response = await _IProductService.GetAll();
            return Ok(response);
        }

        // GET api/<ProductController>/{productId}
        [HttpGet("{id}")]
        public async Task<ActionResult> GetById(int id)
        {
            var response = await _IProductService.GetById(id);
            return Ok(response);
        }

        // POST api/<ProductController>
        [HttpPost]
        public async Task<IActionResult> Post([FromBody] ProductRequest objReq)
        {
            var response = await _IProductService.Create(objReq);
            return Ok(response);
        }
    }
}
