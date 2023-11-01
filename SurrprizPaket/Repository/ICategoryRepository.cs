using SurrprizPaket.Models;

namespace SurrprizPaket.Repository
{
    public interface ICategoryRepository
    {
        List<Category> GetAllCategories();
        Category GetCategoryById(int id);

        Category UpdateCategory(Category category);
        Category CreateCategory(Category category);
        void DeleteCategory(int id);

    }
}
