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

		//public DbSet<User> Users { get; set; }
	}
}
