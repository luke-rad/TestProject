using Domain.Entities;

namespace Infrastructure.Persistence
{
	public class CategoryRepository : ICategoryRepository
	{
		public Task<Category> AddCategoryAsync(Category product)
		{
			throw new NotImplementedException();
		}

		public Task DeleteCategoryAsync(int id)
		{
			throw new NotImplementedException();
		}

		public Task<IEnumerable<Category>> GetAllCategoriesAsync()
		{
			throw new NotImplementedException();
		}

		public Task<Category> GetCategoryByIdAsync(int id)
		{
			throw new NotImplementedException();
		}

		public Task<Category> UpdateCategoryAsync(Category product)
		{
			throw new NotImplementedException();
		}
	}
}
