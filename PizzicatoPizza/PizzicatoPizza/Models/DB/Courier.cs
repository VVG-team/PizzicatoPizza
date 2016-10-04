namespace PizzicatoPizza.Models.DB
{
    public class Courier
    {
        public int Id { get; set; }

        public string Nickname { get; set; }

        public User User { get; set; }

        public Enums.CourierStatusEnum Status { get; set; }
    }
}