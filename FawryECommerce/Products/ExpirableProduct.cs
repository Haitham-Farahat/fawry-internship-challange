using FawryECommerce.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FawryECommerce.Products
{
	public class ExpirableProduct : Product,IShipableOrExpirable
	{
		public DateTime expirationDate { get; }
		public decimal weightInGrams { get; }


		public ExpirableProduct(string name, decimal price, int quantity,DateTime expirationDate,decimal weight ):base(name,price,quantity)
		{
			this.expirationDate= expirationDate;
			weightInGrams=weight;
		}

		public override bool IsExpired()
		{
			return DateTime.Now > expirationDate;
		}

		public override bool IsShipable()
		{
			return true;
		}
	}
}
