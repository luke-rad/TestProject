using Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.Persistence
{
	public class ProductRepository : IProductRepository
	{
		private readonly ApplicationDBContext _dbContext;

		public ProductRepository(ApplicationDBContext dbContext) {
			_dbContext = dbContext;
		}
		public async Task<Product> AddProductAsync(Product product)
		{
			product.CreatedAt = DateTime.Now;
			_dbContext.Products.Add(product);
			await _dbContext.SaveChangesAsync();

			return product;
		}

		public async Task DeleteProductAsync(Product product)
		{
			_dbContext.Products.Remove(product);

			await _dbContext.SaveChangesAsync();
		}

		public async Task<IEnumerable<Product>> GetAllProductsAsync(string name = "")
		{
			return await _dbContext.Products.
				Where(p => p.ProductName.StartsWith(name))
				.ToListAsync();
		}

		public async Task<Product?> GetProductByIdAsync(int id)
		{
			var product = await _dbContext.Products.FirstOrDefaultAsync(p => p.ProductId == id);
			return product;
		}

		public async Task<Product?> UpdateProductAsync(Product product)
		{
			var oldProduct = await _dbContext.Products.FirstOrDefaultAsync(p => p.ProductId == product.ProductId);

			if (oldProduct != null) {
				oldProduct.ProductName = product.ProductName;
				oldProduct.Price = product.Price;
				oldProduct.Description = product.Description;
				oldProduct.StockQuantity = product.StockQuantity;

				await _dbContext.SaveChangesAsync();
				return product;
			}

			return oldProduct;
		}
	}
}
