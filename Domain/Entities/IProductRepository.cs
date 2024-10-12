using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
	public interface IProductRepository
	{
		Task<IEnumerable<Product>> GetAllProductsAsync(string name);
		Task<Product?> GetProductByIdAsync(int id);
		Task<Product> AddProductAsync(Product product);
		Task<Product?> UpdateProductAsync(Product product);
		Task DeleteProductAsync(Product product);


	}
}
