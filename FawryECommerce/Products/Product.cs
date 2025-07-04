using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FawryECommerce.Products
{
	public abstract class Product
	{
		public string name { get; }
		public decimal Price { get; }
		public int Quantity { get; set; }

		protected Product(string name, decimal price, int quantity)
		{
			this.name = name;
			Price = price;
			Quantity = quantity;
		}

		public void ReduceProductCuantity(int amount)
		{
			if (amount > Quantity)
				throw new ArgumentException("Cannot reduce quantity by more than available");

			Quantity -= amount;
		}

		public abstract bool IsExpired();
		public abstract bool IsShipable();
	}
}
