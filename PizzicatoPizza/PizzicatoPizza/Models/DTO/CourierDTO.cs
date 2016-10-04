namespace PizzicatoPizza.Models.DTO
{
    public class CourierDTO
    {
        public int Id { get; set; }

        public string Nickname { get; set; }

        public UserDTO User { get; set; }

        public Enums.CourierStatusEnum Status { get; set; }
    }
}