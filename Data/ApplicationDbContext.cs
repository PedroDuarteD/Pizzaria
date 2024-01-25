
using Microsoft.EntityFrameworkCore;
using Pizzaria.Models;

namespace Pizzaria.Data

{
	public class ApplicationDbContext : DbContext
	{
        public DbSet<PizzasModel> pizzas { get; set; }

        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
            
        }
    }
}
