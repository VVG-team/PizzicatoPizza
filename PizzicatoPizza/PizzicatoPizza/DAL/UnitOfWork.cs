using DAL.Interface;
using DAL.Interfaces;
using DAL.Repositories;
using PizzicatoPizza.Models.DB;
using System;

namespace DAL
{
    public class UnitOfWork : IUnitOfWork, IDisposable
	{
		private MainContext context;

		#region Private Repositories

		private IGenericRepository<User> userRepo;
        private IGenericRepository<Courier> courierRepo;
        private IGenericRepository<Ingredient> ingredientRepo;
        private IGenericRepository<Order> orderRepo;
        private IGenericRepository<Pizza> pizzaRepo;
        private IGenericRepository<Size> sizeRepo;

        #endregion

        public UnitOfWork()
		{
			context = new MainContext();

			userRepo = new GenericRepository<User>(context);
            courierRepo = new GenericRepository<Courier>(context);
            ingredientRepo = new GenericRepository<Ingredient>(context);
            orderRepo = new GenericRepository<Order>(context);
            pizzaRepo = new GenericRepository<Pizza>(context);
            sizeRepo = new GenericRepository<Size>(context);
        }

		public void Save()
		{
			context.SaveChanges();
		}

		#region Repositories Getters

		public IGenericRepository<User> UserRepo
		{
			get
			{
				if (userRepo == null) userRepo = new GenericRepository<User>(context);
				return userRepo;
			}
		}

        public IGenericRepository<Courier> CourierRepo
        {
            get
            {
                if (courierRepo == null) courierRepo = new GenericRepository<Courier>(context);
                return courierRepo;
            }
        }

        public IGenericRepository<Ingredient> IngredientRepo
        {
            get
            {
                if (ingredientRepo == null) ingredientRepo = new GenericRepository<Ingredient>(context);
                return ingredientRepo;
            }
        }

        public IGenericRepository<Order> OrderRepo
        {
            get
            {
                if (orderRepo == null) orderRepo = new GenericRepository<Order>(context);
                return orderRepo;
            }
        }

        public IGenericRepository<Pizza> PizzaRepo
        {
            get
            {
                if (pizzaRepo == null) pizzaRepo = new GenericRepository<Pizza>(context);
                return pizzaRepo;
            }
        }

        public IGenericRepository<Size> SizeRepo
        {
            get
            {
                if (sizeRepo == null) sizeRepo = new GenericRepository<Size>(context);
                return sizeRepo;
            }
        }

        #endregion

        #region Dispose
        // https://msdn.microsoft.com/ru-ru/library/system.idisposable(v=vs.110).aspx

        private bool disposed = false;

		protected virtual void Dispose(bool disposing)
		{
			if (!this.disposed)
			{
				if (disposing)
				{
					context.Dispose();
				}
			}
			this.disposed = true;
		}

		public void Dispose()
		{
			Dispose(true);
			GC.SuppressFinalize(this);
		}

		#endregion
	}
}
