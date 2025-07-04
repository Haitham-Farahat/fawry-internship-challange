using FawryECommerce.Products;
using FawryECommerce.Service;
using FawryECommerce.Services;
using FawryECommerce.Shopping;

namespace FawryECommerce
{
    internal class Program
    {
        static void Main(string[] args)
        {
			var cheese = new ExpirableProduct("Cheese", 100, 10, DateTime.Now.AddDays(5),700);
			
			var tv = new ShipableProduct("TV", 10000, 5, 15000);
			
			var scratchCard = new NotShipableProduct("Mobile scratch card", 50, 100);

			var customer = new Customer("Sharawy Mohamed", 32000);

			var _shipingService = new ShipingService();
			var _checkoutService = new CheckoutService(_shipingService);

			var cart = new Cart();
			cart.Add(cheese, 2,cheese.weightInGrams);
			cart.Add(tv, 3,tv.weightInGrams);
			cart.Add(scratchCard, 1);
			_checkoutService.Checkout(customer, cart);

		}
    }
}
