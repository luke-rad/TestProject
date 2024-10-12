using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
	public class Category
	{
		public int CategoryId { get; set; }
		public required string CategoryName { get; set; }

		public DateTime CreatedAt { get; set; }


		public List<Product>? Products { get; set; }
		public List<ProductCategory>? ProductCategories { get; set; }

	}
}
