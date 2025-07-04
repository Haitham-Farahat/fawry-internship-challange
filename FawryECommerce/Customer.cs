using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FawryECommerce
{
	public class Customer
	{
		public string name { get; set; }
		public decimal balance { get; private set; } = 0.0m;

		public Customer(string _name, decimal balance)
		{
			name = _name;
			this.balance = balance;
		}

		public void PayOrderAmount(decimal amount)
		{
			balance -= amount;
			return;
		}
	}
}
