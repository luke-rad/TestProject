using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
	public interface ICategoryRepository
	{
		Task<IEnumerable<Category>> GetAllCategoriesAsync();
		Task<Category> GetCategoryByIdAsync(int id);
		Task<Category> AddCategoryAsync(Category product);
		Task<Category> UpdateCategoryAsync(Category product);
		Task DeleteCategoryAsync(int id);
	}
}
