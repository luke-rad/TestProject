using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
	public class ProductCategory
	{
		public int ProductId { get; set; }
		public required Product Product { get; set; }

		public int CategoryId { get; set; }
		public required Category Category { get; set; }
	}
}
