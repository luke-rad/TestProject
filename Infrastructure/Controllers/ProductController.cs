using Domain.Entities;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Infrastructure.Controllers
{
	[Route("api/[controller]")]
	[ApiController]
	public class ProductController : ControllerBase
	{
		private readonly IProductRepository _productRepository;

		public ProductController(IProductRepository productRepository)
		{
			_productRepository = productRepository;
		}

		[HttpGet]
		public async Task<ActionResult<IEnumerable<Product>>> GetProducts([FromQuery] string name = "")
		{
			var products = await _productRepository.GetAllProductsAsync(name);
			 return Ok(products);
			
		}

		[HttpGet("{id}")]
		public async Task<ActionResult<Product>> GetProduct(int id)
		{
			var product = await _productRepository.GetProductByIdAsync(id);
			if (product == null)
			{
				return NotFound();
			}
			return Ok(product);
			
		}

		[HttpPost]
		public async Task<ActionResult<Product>> PostProduct(Product product)
		{
			var newProduct = await _productRepository.AddProductAsync(product);
			return Ok(newProduct);
			
		}

		[HttpPut]
		public async Task<ActionResult<Product>> PutProduct(Product product)
		{
			
			var alteredProduct = await _productRepository.UpdateProductAsync(product);

			if (alteredProduct == null)
			{
				return NotFound();
			}
			return Ok(alteredProduct);
			
		}

		[HttpDelete("{id}")]
		public async Task<IActionResult> DeleteProduct(int id)
		{
			var product = await _productRepository.GetProductByIdAsync(id);
			if (product == null)
			{
				return NotFound();
			}
			await _productRepository.DeleteProductAsync(product);
			return Ok("Product deleted!");
			
		}
	}
}
