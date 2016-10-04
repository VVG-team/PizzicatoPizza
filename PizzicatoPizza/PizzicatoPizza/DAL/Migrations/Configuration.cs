namespace DAL.Migrations
{
    using System;
    using System.Collections.Generic;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<DAL.MainContext> 
    {
		Random random = new Random();

        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(DAL.MainContext context)
        {
			var roles = new List<Role> 
			{
				new Role() { Name = "Driver", Description = "Driver" },
				new Role() { Name = "Operator", Description = "Operator" },
				new Role() { Name = "Client", Description = "Client" },
				new Role() { Name = "ReportViewer", Description = "Report Viewer" },
				new Role() { Name = "Administrator", Description = "Administrator" },
				new Role() { Name = "Supporter", Description = "Support Service"},
				new Role() { Name = "FreeDriver", Description = "Free Driver" }
			};

			roles.ForEach(s => context.Roles.AddOrUpdate(p => p.Name, s));
			context.SaveChanges();

			var users = new List<User>
			{
				new User()
				{
					UserName = "admin",
					Password = "password",
					Email = "admin@gmail.com",
					RoleId = 5,
					Lang = "en-us",
					RegistrationDate = DateTime.Now
				},
				new User()
				{
					UserName = "driver",
					Password = "password",
					Email = "driver@gmail.com",
					RoleId = 1,
					Lang = "en-us",
					RegistrationDate = DateTime.Now
				}
			};

			users.ForEach(u => context.Users.AddOrUpdate(p => p.UserName, u));

			
			}
        }
    }
}
