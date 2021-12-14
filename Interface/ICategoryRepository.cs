using MVCDemoS.Models;

namespace MVCDemoS.Interface
{
    public interface ICategoryRepository
    {
        Task<Category> AddCategory(Category category);
        Task<Category> UpdateCategory(Category category);
        Task DeleteCategory(Category category);
        Task<IList<Category>> GetCategories();
        Task<Category> GetCategory(int id);
    }
}
