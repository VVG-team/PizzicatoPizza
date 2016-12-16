namespace PizzicatoPizza.Migrations
{
    using Models.DB;
    using System.Collections.Generic;
    using System.Data.Entity.Migrations;

    internal sealed class Configuration : DbMigrationsConfiguration<DAL.MainContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(DAL.MainContext context)
        {
            var users = new List<User>
            {
                new User()
                {
                    Username = "admin",
                    Password = "qwerty",
                    Role = Models.Enums.RoleEnum.Administrator,
                    Name = "Grigory",
                    Surname = "Cherchel",
                    Email = "grigorycherchel@mail.com",
                    Phone = "+380003455767",
                    Photo = "admin.jpg",
                    Language = Models.Enums.LanguageEnum.English
                },
                new User()
                {
                    Username = "client",
                    Password = "qwerty",
                    Role = Models.Enums.RoleEnum.Client,
                    Name = "Vasily",
                    Surname = "Poklitar",
                    Email = "vasilypoklitar@mail.com",
                    Phone = "+389995778675",
                    Photo = "default.png",
                    Language = Models.Enums.LanguageEnum.English
                },
                new User()
                {
                    Username = "operator",
                    Password = "qwerty",
                    Role = Models.Enums.RoleEnum.Operator,
                    Name = "Vitaly",
                    Surname = "Mosoriuk",
                    Email = "vitalymosoriuk@mail.com",
                    Phone = "+382229083412",
                    Photo = "default.png",
                    Language = Models.Enums.LanguageEnum.English
                },
                new User()
                {
                    Username = "moderator",
                    Password = "qwerty",
                    Role = Models.Enums.RoleEnum.Moderator,
                    Name = "Petro",
                    Surname = "Kapitsky",
                    Email = "petrokapitski@mail.com",
                    Phone = "+380909883345",
                    Photo = "default.png",
                    Language = Models.Enums.LanguageEnum.English
                }
            };

            users.ForEach(u => context.Users.AddOrUpdate(p => p.Username, u));

            var standardSize = new Size()
            {
                Name = "Standard",
                Diameter = 40,
                Coefficient = 1
            };

            var smallSize = new Size()
            {
                Name = "Small",
                Diameter = 28,
                Coefficient = 0.7
            };

            var bigSize = new Size()
            {
                Name = "Big",
                Diameter = 55,
                Coefficient = 1.4
            };

            var sizes = new List<Size>
            {
                standardSize,
                smallSize,
                bigSize
            };

            sizes.ForEach(s => context.Sizes.AddOrUpdate(p => p.Name, s));

            var couriers = new List<Courier>
            {
                new Courier()
                {
                    Nickname="FastMan",
                    User = new User()
                    {
                        Name = "Patrick",
                        Surname = "Ternel",
                        Password = "1234",
                        Email = "Ternel@mail.ru",
                        Username = "PatrickT",
                        Role = Models.Enums.RoleEnum.Courier,
                        Phone = "+380996520007",
                        Photo = "default.png",
                        Language = Models.Enums.LanguageEnum.English
                    },

                    Status=Models.Enums.CourierStatusEnum.Available

                }
            };

            couriers.ForEach(c => context.Couriers.AddOrUpdate(p => p.Nickname, c));

            var pizzas = new List<Pizza>
            {
                new Pizza()
                {
                    Name = "Boston",
                    Cost = 69.99M,
                    Weight = 370,
                    Image = "Boston.png",
                    Size = standardSize
                },
                new Pizza()
                {
                    Name = "Karbonara",
                    Cost = 76.99M,
                    Weight = 380,
                    Image = "Karbonara.png",
                    Size = standardSize
                },
                new Pizza()
                {
                    Name = "Margarita",
                    Cost = 69.99M,
                    Weight = 370,
                    Image = "Margarita.png",
                    Size = standardSize
                },
                new Pizza()
                {
                    Name = "Peperoni",
                    Cost = 86.99M,
                    Weight = 395,
                    Image = "Peperoni.png",
                    Size = standardSize
                },
                new Pizza()
                {
                    Name = "Provans",
                    Cost = 57.99M,
                    Weight = 370,
                    Image = "Provans.png",
                    Size = standardSize
                },
                new Pizza()
                {
                    Name = "Tehas",
                    Cost = 69.99M,
                    Weight = 370,
                    Image = "Tehas.png",
                    Size = standardSize
                }
            };

            pizzas.ForEach(p => context.Pizzas.AddOrUpdate(c => c.Name, p));

            context.SaveChanges();
        }
    }
}
