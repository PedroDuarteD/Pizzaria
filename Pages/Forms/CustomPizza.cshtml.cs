using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Pizzaria.Models;

namespace Pizzaria.Pages.Forms
{
    public class CustomPizzaModel : PageModel
    {

        //allow use Pizzas model in view cshtml
        [BindProperty]
        public PizzasModel Pizzas { get; set; }
        public void OnGet()
        {

        }

        public IActionResult OnPost()
        {


            return RedirectToPage("/Checkout/Checkout", new  { Pizzas.name, Pizzas.family, Pizzas.price});
        }
    }
}
