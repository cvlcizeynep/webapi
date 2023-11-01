using SurrprizPaket.Models;

namespace SurrprizPaket.Service
{
    public interface ICategoryService
    {
        List<Category> GetAllCategories();
        Category GetCategoryById(int id);

        Category UpdateCategory(Category category);
        Category CreateCategory(Category category);
        void DeleteCategory(int id);



    }
}
