using PizzicatoPizza.Models.DB;

namespace PizzicatoPizza.Models.DTO
{
    public class PizzaIngredientDTO
    {
        public int PizzaId { get; set; }

        public Pizza Pizza { get; set; }

        public int IngredientId { get; set; }

        public Ingredient Ingredient { get; set; }

        public int Count { get; set; }

        public decimal Cost { get; set; }
    }
}