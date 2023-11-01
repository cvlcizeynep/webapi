using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SurrprizPaket.Models;
using SurrprizPaket.Service;

namespace SurrprizPaket.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CategoryController : ControllerBase
    {

        private ICategoryService _categoryService;
        public CategoryController()
        {
            _categoryService = new CategoryService();

        }

        [HttpGet]
        public List<Category> Get()
        {
            return _categoryService.GetAllCategories();

        }
        [HttpGet("{id}")]
        public Category Get(int id)
        {
            return _categoryService.GetCategoryById(id);

        }
        [HttpDelete]
        public void Delete(int id)
        {
            _categoryService.DeleteCategory(id);

        }
        [HttpPost]
        public Category Post([FromBody] Category category)
        {

            return _categoryService.CreateCategory(category);

        }
        [HttpPut]
        public Category Put([FromBody] Category category)
        {
            return _categoryService.UpdateCategory(category);
        }



    }
}
