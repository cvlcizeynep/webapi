using SurrprizPaket.Models;

namespace SurrprizPaket.Repository
{
    public interface IProductRepository
    {
        List<Product> GetAllProducts();
        Product GetProductById(int id);
        Product CreateProduct(Product product);
        void DeleteProduct(int id);

        Product UpdateProduct(Product product);

    }
}
