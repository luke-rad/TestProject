using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
	public class Product
	{
		public int ProductId { get; set; }
		public required string ProductName { get; set; }
		public decimal Price { get; set; }
		public required string Description { get; set; }
		public int StockQuantity { get; set; }

		public DateTime CreatedAt { get; set; }

		public List<Category>? Categories { get; set; }
		public List<ProductCategory>? ProductCategories { get; set; }

		
	}
}
