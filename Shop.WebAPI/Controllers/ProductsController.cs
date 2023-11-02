using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Shop.Business.Abstract;

namespace Shop.WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductsController : ControllerBase
    {
        // LooselyCoupled : Zayıf bağımlılık
      private readonly  IProductService _productService;

        public ProductsController(IProductService productService)
        {
            _productService = productService;
        }

        [HttpGet("GetAll")]
        public IActionResult GetAll()
        {
            var result = _productService.GetAllProducts();

            if (result.IsSuccess)
            {
                return Ok(result);
            }
            return BadRequest(result.IsSuccess);
        }


    }
}
