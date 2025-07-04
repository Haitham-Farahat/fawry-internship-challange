using FawryECommerce.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FawryECommerce.Service
{
	public class ShipingService
	{
		public void ShowCardItems(List<IShipableOrExpirable> items)
		{
			var groupedCartItems = items
				.GroupBy(i => i.name)
				.Select(group => new{ Name = group.Key, Count = group.Count(), Weight = group.First().weightInGrams*group.Count() });

			decimal totalWeight = 0.0m;

		    Console.WriteLine("** Shipment notice **");
			foreach (var item in groupedCartItems)
			{
				Console.WriteLine($"{item.Count}x {item.Name}    {item.Weight}g");
				totalWeight += item.Weight;
			}

			Console.WriteLine($"Total package weight {totalWeight / 1000}kg\n");
		}
	}
}
