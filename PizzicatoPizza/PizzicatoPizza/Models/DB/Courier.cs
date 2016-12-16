using PizzicatoPizza.Models.Enums;

namespace PizzicatoPizza.Models.DB
{
    public class Courier
    {
        public int Id { get; set; }

        public string Nickname { get; set; }

        public CourierStatusEnum Status { get; set; }

        public User User { get; set; }
    }
}