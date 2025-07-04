using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FawryECommerce.Interfaces
{
	public interface IShipableOrExpirable
	{
		string name { get; }
		decimal weightInGrams { get; }
	}
}
