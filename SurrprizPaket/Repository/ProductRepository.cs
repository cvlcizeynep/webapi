using SurrprizPaket.Models;

namespace SurrprizPaket.Repository
{
    public class ProductRepository : IProductRepository
    {



        private readonly BaseDbContext _baseDbContext;

        public ProductRepository()
        {
        }

        public ProductRepository(BaseDbContext baseDbContext)
        {
            _baseDbContext = baseDbContext;
        }

        public Product CreateProduct(Product product)
        {
            Product product1 = new Product()
            {
                Name = product.Name,
                Description = product.Description,
                Price = product.Price
            };

            _baseDbContext.Products.Add(product1);
            _baseDbContext.SaveChanges();
            return product1;




        }

        public void DeleteProduct(int id)
        {
            var product = _baseDbContext.Products.Find(id);
            _baseDbContext.Products.Remove(product);
            _baseDbContext.SaveChanges();



        }

        public List<Product> GetAllProducts()
        {
            var products = _baseDbContext.Products.ToList();
            return products;

        }

        public Product GetProductById(int id)
        {
            var product = _baseDbContext.Products.Find(id);
            return product;


        }

        public Product UpdateProduct(Product product)
        {
            _baseDbContext.Products.Update(product);
            _baseDbContext.SaveChanges();
            return product;
        }



    }
}