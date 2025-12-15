using CrudApi.Models;

namespace CrudApi.Repositories;

public interface ICategoryRepository
{
    Task<IEnumerable<Category>> GetAllAsync();
    Task<Category?> GetByIdAsync(int id);
    Task AddCategory(Category category);
    Task DeleteCategoryAsync(int id);
    Task UpdateCagoryAsync(Category category);
}
