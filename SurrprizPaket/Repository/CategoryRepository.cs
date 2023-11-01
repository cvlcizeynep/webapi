using SurrprizPaket.Models;
using System.Buffers.Text;

namespace SurrprizPaket.Repository
{
    public class CategoryRepository : ICategoryRepository
     {
        public CategoryRepository() { }

        private readonly BaseDbContext _baseDbContext;
        public CategoryRepository(BaseDbContext baseDbContext)
        {
            _baseDbContext = baseDbContext;
        }

        public Category CreateCategory(Category category)
        {
            Category category1 = new Category()
            {
                Name = category.Name,
                Description = category.Description,
                id = category.id
            };

            _baseDbContext.Categories.Add(category1);
            _baseDbContext.SaveChanges();
            return category1;


        }
        public void DeleteCategory(int id)
        {
            var category=   _baseDbContext.Categories.Find(id);
            _baseDbContext.Categories.Remove(category);
            _baseDbContext.SaveChanges();

        }

        public List<Category> GetAllCategories()
        {
            var category = _baseDbContext.Categories.ToList();
            return category;
        }

        public Category GetCategoryById(int id)
        {
            var category = _baseDbContext.Categories.Find(id);
            return category;
        }

        public Category UpdateCategory(Category category)
        {

            _baseDbContext.Categories.Update(category);
            _baseDbContext.SaveChanges();
            return category;


        }
            
    }
}
