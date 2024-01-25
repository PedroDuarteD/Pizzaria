using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Pizzaria.Data;
using Pizzaria.Models;

namespace Pizzaria.Pages.Checkout
{
    [BindProperties(SupportsGet =true)]
    public class CheckoutModel : PageModel
    {

		public string name { get; set; }
		public string family { get; set; }
		public double price { get; set; }


		private readonly ApplicationDbContext _context;
		public CheckoutModel(ApplicationDbContext context)
		{
			_context = context;
		}

		public void OnGet()
        {
            if (string.IsNullOrWhiteSpace(name))
            {
                name = "Name";
            }

			if (string.IsNullOrWhiteSpace(family))
			{
				family = "Family";
			}


			if (double.IsNegative(price))
			{
				price = 10;
			}


			PizzasModel pizzas = new PizzasModel();
			pizzas.name = name;
			pizzas.family = family;
			pizzas.price = price;

			_context.pizzas.Add(pizzas);
			_context.SaveChanges();

		}
	}
}
