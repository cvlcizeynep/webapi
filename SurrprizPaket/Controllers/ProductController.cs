using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SurrprizPaket.Models;
using SurrprizPaket.Service;

namespace SurrprizPaket.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
     private   IProductService _productService;

        public ProductController()
        {
            _productService = new ProductService();

        }

        [HttpGet]
        public List<Product> Get()
        {
            return _productService.GetAllProducts();

        }
        [HttpGet("{id}")]
        public Product Get(int id)
        {
            return _productService.GetProductById(id);

        }
        [HttpDelete]
        public void Delete(int id)
        {
             _productService.DeleteProduct(id);

        }
        [HttpPost]
        public Product Post([FromBody]Product product)
        {

            return _productService.CreateProduct(product);

        }
        [HttpPut]
        public Product Put([FromBody]Product product)
        {
            return _productService.UpdateProduct(product);
        }










    }
}
