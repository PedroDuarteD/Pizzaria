using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Pizzaria.Data;
using Pizzaria.Models;

namespace Pizzaria.Pages.Orders
{
    public class OrdersModel : PageModel
    {
		public List<PizzasModel> allPizza = new List<PizzasModel>();


        private readonly ApplicationDbContext _context;
        public OrdersModel(ApplicationDbContext context)
        {
            _context = context;
        }

		public void OnGet()
        {
            allPizza = _context.pizzas.ToList();
        }


    }
}
