using DAL.Interfaces;
using PizzicatoPizza.Models.DB;

namespace DAL.Interface
{
    public interface IUnitOfWork
	{
		IGenericRepository<User> UserRepo { get; }
        IGenericRepository<Courier> CourierRepo { get; }
        IGenericRepository<Ingredient> IngredientRepo { get; }
        IGenericRepository<Order> OrderRepo { get; }
        IGenericRepository<Pizza> PizzaRepo { get; }
        IGenericRepository<Size> SizeRepo { get; }
        IGenericRepository<OrderPizza> OrderPizzaRepo { get; }
        IGenericRepository<PizzaIngredient> PizzaIngredientRepo { get; }

        void Dispose();

		void Save();
	}
}
