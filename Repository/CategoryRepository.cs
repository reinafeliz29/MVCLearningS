using Microsoft.EntityFrameworkCore;
using MVCDemoS.Data;
using MVCDemoS.Interface;
using MVCDemoS.Models;

namespace MVCDemoS.Repository
{
    public class CategoryRepository : ICategoryRepository
    {
        private readonly ApplicationConnectDb _context;

        public CategoryRepository(ApplicationConnectDb context)
        {
            _context = context;
        }

        public async Task<Category> AddCategory(Category category)
        {
            _context.Add(category);
            await _context.SaveChangesAsync();
            return category;
        }

        public async Task DeleteCategory(Category category)
        {
            _context.Categories.Remove(category);
            await _context.SaveChangesAsync();
        }

        public async Task<IList<Category>> GetCategories()
        {
            var data = await _context.Categories.ToListAsync();
            return data;
        }
        public async Task<Category> GetCategory(int id)
        {
            var category = await _context.Categories.FindAsync(id);
            if (category != null) return category;
            return null;
        }
        public async Task<Category> UpdateCategory(Category category)
        {
            _context.Categories.Update(category);
            await _context.SaveChangesAsync();
            return category;
        }
    }
}
