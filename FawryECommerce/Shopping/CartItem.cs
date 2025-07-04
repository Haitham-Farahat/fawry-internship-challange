using FawryECommerce.Products;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace FawryECommerce.Shopping
{
	public class CartItem
	{
		public Product Product { get; }
		public decimal ProductWaightInGrams { get; set; } = 0.0m;
		public int Quantity { get; set; }

		public CartItem(Product product, int quantity,decimal productWeight)
		{
			Product = product;
			Quantity = quantity;
			ProductWaightInGrams = productWeight;
		}
	}
}
