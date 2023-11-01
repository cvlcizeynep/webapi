using SurrprizPaket.Models;

namespace SurrprizPaket.Service
{
    public interface IProductService
    {
        List<Product> GetAllProducts();
        Product GetProductById(int id);
        Product CreateProduct(Product product);
        void DeleteProduct(int id);

        Product UpdateProduct(Product product);


    }
}
