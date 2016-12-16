using PizzicatoPizza.Models.DB;
using PizzicatoPizza.Models.Enums;

namespace PizzicatoPizza.Models.DTO
{
    public class CourierDTO
    {
        public int Id { get; set; }

        public string Nickname { get; set; }

        public CourierStatusEnum Status { get; set; }

        public User User { get; set; }
    }
}