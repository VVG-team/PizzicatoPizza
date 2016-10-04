namespace DAL.Migrations
{
    using PizzicatoPizza.Models.DB;
    using System.Collections.Generic;
    using System.Data.Entity.Migrations;

    internal sealed class Configuration : DbMigrationsConfiguration<DAL.MainContext>
    { 
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(MainContext context)
        {
            var users = new List<User>
            {
                new User()
                {
                    Username = "admin",
                    Password = "qwerty",
                    Role = PizzicatoPizza.Models.Enums.RoleEnum.Administrator,
                    Name = "Grigory",
                    Surname = "Cherchel",
                    Email = "grigorycherchel@mail.com",
                    Phone = "+380003455767",
                    Photo = "admin.jpg",
                    Language = PizzicatoPizza.Models.Enums.LanguageEnum.English
                },
                new User()
                {
                    Username = "client",
                    Password = "qwerty",
                    Role = PizzicatoPizza.Models.Enums.RoleEnum.Client,
                    Name = "Vasily",
                    Surname = "Poklitar",
                    Email = "vasilypoklitar@mail.com",
                    Phone = "+389995778675",
                    Photo = "default.png",
                    Language = PizzicatoPizza.Models.Enums.LanguageEnum.English
                },
                new User()
                {
                    Username = "operator",
                    Password = "qwerty",
                    Role = PizzicatoPizza.Models.Enums.RoleEnum.Operator,
                    Name = "Vitaly",
                    Surname = "Mosoriuk",
                    Email = "vitalymosoriuk@mail.com",
                    Phone = "+382229083412",
                    Photo = "default.png",
                    Language = PizzicatoPizza.Models.Enums.LanguageEnum.English
                },
                new User()
                {
                    Username = "moderator",
                    Password = "qwerty",
                    Role = PizzicatoPizza.Models.Enums.RoleEnum.Moderator,
                    Name = "Petro",
                    Surname = "Kapitsky",
                    Email = "petrokapitski@mail.com",
                    Phone = "+380909883345",
                    Photo = "default.png",
                    Language = PizzicatoPizza.Models.Enums.LanguageEnum.English
                }
            };

            users.ForEach(u => context.Users.AddOrUpdate(p => p.Username, u));

            var sizes = new List<Size>
            {
                new Size()
                {
                    Name = "Standard",
                    Diameter = 40,
                    Coefficient = 1
                },
                new Size()
                {
                    Name = "Small",
                    Diameter = 28,
                    Coefficient = 0.7,
                },
                new Size()
                {
                    Name = "Big",
                    Diameter = 55,
                    Coefficient = 1.4
                }
            };

            sizes.ForEach(s => context.Sizes.AddOrUpdate(p => p.Name, s));

            context.SaveChanges();
        }
    }
}
