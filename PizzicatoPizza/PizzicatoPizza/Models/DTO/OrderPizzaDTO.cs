using PizzicatoPizza.Models.DB;

namespace PizzicatoPizza.Models.DTO
{
    public class OrderPizzaDTO
    {
        public int OrderId { get; set; }

        public Order Order { get; set; }

        public int PizzaId { get; set; }

        public Pizza Pizza { get; set; }

        public int Count { get; set; }

        public decimal Cost { get; set; }
    }
}