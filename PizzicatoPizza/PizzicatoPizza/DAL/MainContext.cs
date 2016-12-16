using PizzicatoPizza.Models.DB;
using System.Data.Entity;

namespace DAL
{
    public class MainContext : DbContext
	{
		public MainContext() : base("PizzicatoDB")
		{
			this.Configuration.LazyLoadingEnabled = true;
		}

		public MainContext(string connString) : base(connString)
		{
			this.Configuration.LazyLoadingEnabled = true;
		}

		public DbSet<User> Users { get; set; }
        public DbSet<Courier> Couriers { get; set; }
        public DbSet<Ingredient> Ingredients { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<Pizza> Pizzas { get; set; }
        public DbSet<Size> Sizes { get; set; }
        public DbSet<OrderPizza> OrderPizzas { get; set; }
        public DbSet<PizzaIngredient> PizzaIngredients { get; set; }
    }
}
