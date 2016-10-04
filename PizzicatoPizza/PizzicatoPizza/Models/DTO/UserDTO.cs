namespace PizzicatoPizza.Models.DTO
{
    public class UserDTO
    {
        public int Id { get; set; }

        public string Username { get; set; }

        public string Password { get; set; }

        public Enums.RoleEnum Role { get; set; }

        public string Name { get; set; }

        public string Surname { get; set; }

        public string Email { get; set; }

        public string Phone { get; set; }

        public string Photo { get; set; }

        public Enums.LanguageEnum Language { get; set; }
    }
}