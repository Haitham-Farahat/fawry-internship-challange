using FawryECommerce.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FawryECommerce.Products
{
	public class ShipableProduct : Product, IShipableOrExpirable
	{
		public decimal weightInGrams { get; }
		public ShipableProduct(string name, decimal price, int quantity, decimal weight) : base(name, price, quantity)
		{
			weightInGrams = weight;
		}
		public override bool IsExpired()
		{
			return false;
		}
		public override bool IsShipable()
		{
			return true; 
		}
	}
}
