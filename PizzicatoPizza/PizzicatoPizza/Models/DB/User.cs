using PizzicatoPizza.Models.Enums;

namespace PizzicatoPizza.Models.DB
{
    public class User
    {
        public int Id { get; set; }

        public string Username { get; set; }

        public string Password { get; set; }

        public RoleEnum Role { get; set; }

        public string Name { get; set; }

        public string Surname { get; set; }

        public string Email { get; set; }

        public string Phone { get; set; }

        public string Address { get; set; }

        public string Photo { get; set; }

        public LanguageEnum Language { get; set; }
    }
}