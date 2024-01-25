using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;

namespace Pizzaria.Models
{

	public class PizzasModel
    {
        public int Id { get; set; }
        public string name { get; set; }
        public string family { get; set; }
        public double price  { get; set; }

    }
}
