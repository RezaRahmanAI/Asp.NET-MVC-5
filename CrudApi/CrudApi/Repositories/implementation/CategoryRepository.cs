using CrudApi.Data;
using CrudApi.Models;
using CrudApi.Repositories;
using Microsoft.EntityFrameworkCore;

namespace CrudApi.Repositories;

public class CategoryRepository : ICategoryRepository
{
    private readonly CrudDbContext _dbContext;
    public CategoryRepository(CrudDbContext dbContext)
    {
        _dbContext = dbContext;
    }

    public async Task AddCategory(Category category)
    {
        await _dbContext.Categories.AddAsync(category);
        await _dbContext.SaveChangesAsync();
    }

    public async Task DeleteCategoryAsync(int id)
    {
        var categoy = await _dbContext.Categories.FindAsync(id);
        if (categoy != null)
        {
            _dbContext.Categories.Remove(categoy);
            await _dbContext.SaveChangesAsync();
        }
    }

    public async Task<IEnumerable<Category>> GetAllAsync()
    {
        return await _dbContext.Categories.ToListAsync();
    }

    public async Task<Category?> GetByIdAsync(int id)
    {
        return await _dbContext.Categories.FindAsync(id);
    }

    public async Task UpdateCagoryAsync(Category category)
    {
        _dbContext.Categories.Update(category);
        await _dbContext.SaveChangesAsync();
    }
}
