using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Pizzaria.Models;

namespace Pizzaria.Pages
{
    [BindProperties]
    public class PizzaModel : PageModel
	{


      
        public  List<PizzasModel> allPizzas = new List<PizzasModel>()
        {
            new PizzasModel()
            {
               name="Chicago Deep-Dish",
               family="Deep",
               price=10,
            },


			 new PizzasModel()
			{
			   name="New York-style",
			   family="York",
			   price=20,
			},


			  new PizzasModel()
			{
			   name="Detroit-style",
			   family="Detroit",
			   price=30,
			},

			   new PizzasModel()
			{
			   name="California-style",
			   family="California",
			   price=50,
			},
		};

		public void OnGet()
        {
        }
    }
}
