using FawryECommerce.Interfaces;
using FawryECommerce.Service;
using FawryECommerce.Shopping;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FawryECommerce.Services
{
	public class CheckoutService
	{
		private readonly ShipingService _shippingService;
		private static decimal ShipingCostPerKiloGram = 30m;
		public CheckoutService(ShipingService shippingService)
		{
			_shippingService = shippingService;
		}

		public void Checkout(Customer customer, Cart cart)
		{
			decimal subTotal=cart.CalculateSubtotal(); 
			decimal shippingCost = CalculateShipingCost(cart);
			decimal totalCost = subTotal+shippingCost;

			if (customer.balance < totalCost)
			{
				throw new Exception("Insufficient customer balance!");
			}

			customer.PayOrderAmount(totalCost);

			foreach (var item in cart.Items())
			{
				item.Product.ReduceProductCuantity(item.Quantity);
			}

			var ShippableItems = new List<IShipableOrExpirable>();
			foreach (var item in cart.Items())
			{
				if (item.Product is IShipableOrExpirable)
				{
					for (int i = 0; i < item.Quantity; i++)
					{
						ShippableItems.Add((IShipableOrExpirable)item.Product);
					}
				}
			}

			if (ShippableItems.Any())
			{
				_shippingService.ShowCardItems(ShippableItems);
			}

			PrintCardInvoice(cart, subTotal, shippingCost, totalCost, customer);
		}

		private decimal CalculateShipingCost(Cart cart)
		{
			decimal totalWeight = 0.0m;
			foreach (var item in cart.Items())
			{
				if (item.Product is IShipableOrExpirable)
				{
					totalWeight += item.ProductWaightInGrams * item.Quantity;
				}
			}

			return (totalWeight / 1000) * ShipingCostPerKiloGram;
		}

		private void PrintCardInvoice(Cart cart, decimal subTotal, decimal shippingCost, decimal totalAmount, Customer customer)
		{
			Console.WriteLine("** Checkout receipt **");
			decimal totalWeight = 0.0m;
			foreach (var item in cart.Items())
			{
				Console.WriteLine($"{item.Quantity}x   {item.Product.name}   {item.Product.Price * item.Quantity}");
			    totalWeight+=item.Quantity*item.ProductWaightInGrams; 
			}
			Console.WriteLine($"Total package weight: {totalWeight / 1000}kg");

			Console.WriteLine("------------------------------------------");
			Console.WriteLine($"Subtotal    {subTotal}");
			Console.WriteLine($"Shipping    {shippingCost}");
			Console.WriteLine($"Amount    {totalAmount}");
		}
	}
}
