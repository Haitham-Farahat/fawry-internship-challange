using FawryECommerce.Products;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FawryECommerce.Shopping
{
	public class Cart
	{
		private List<CartItem> cartItems = new List<CartItem>();
		public void Add(Product product, int quantity, decimal productWeight=0)
		{
			if (product.Quantity < quantity)
			{
				throw new Exception($"Sorry, we can't proviede this quantity:{quantity}, of this product only {product.Quantity} are provided currently!");
			}

			if (product.IsExpired())
			{
				throw new Exception($"Product {product.name} is expired!");
			}

			var itemIndex = cartItems.FindIndex(i => i.Product == product);
			if (itemIndex > -1)
			{
				cartItems[itemIndex].Quantity += quantity;
			}
			else
			{
				cartItems.Add(new CartItem(product, quantity,productWeight));
			}
		}

		public List<CartItem> Items()
		{
			return cartItems;
		}
		public bool IsEmpty()
		{
			return !cartItems.Any();
		}

		public decimal CalculateSubtotal()
		{
			return cartItems.Sum(item => item.Product.Price * item.Quantity);
		}
	}
}

