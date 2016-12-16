using System.ComponentModel.DataAnnotations;

namespace PizzicatoPizza.Models.DB
{
    public class OrderPizza
    {
        [Key]
        public int OrderId { get; set; }

        public Order Order { get; set; }

        public int PizzaId { get; set; }

        public Pizza Pizza { get; set; }

        public int Count { get; set; }

        public decimal Cost { get; set; }
    }
}