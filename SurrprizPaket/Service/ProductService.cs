using SurrprizPaket.Models;
using SurrprizPaket.Repository;

namespace SurrprizPaket.Service
{
    public class ProductService : IProductService
    {

        IProductRepository _productRepository;
        public ProductService()
        {
            _productRepository = new ProductRepository();

        }

        

        public Product CreateProduct(Product product)
        {
          return  _productRepository.CreateProduct(product);


        }

        public void DeleteProduct(int id)
        {
            _productRepository.DeleteProduct(id);
        }

        public List<Product> GetAllProducts()
        {
            return _productRepository.GetAllProducts();


        }

        public Product GetProductById(int id)
        {
            return _productRepository.GetProductById(id);
        }

        public Product UpdateProduct(Product product)
        {
          return  _productRepository.UpdateProduct(product);


        }
    }
}
