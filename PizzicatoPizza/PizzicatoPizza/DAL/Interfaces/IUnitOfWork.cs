namespace DAL.Interface
{
    public interface IUnitOfWork
	{
		//IGenericRepository<User> UserRepo { get; }

		void Dispose();

		void Save();
	}
}
