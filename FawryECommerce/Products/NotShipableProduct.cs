using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FawryECommerce.Products
{
	public class NotShipableProduct: Product
	{
		public NotShipableProduct(string name, decimal price, int quantity) : base(name, price, quantity)
		{
		
		}
		public override bool IsExpired()
		{
			return false; 
		}
		public override bool IsShipable()
		{
			return false;
		}
	}
	
}
