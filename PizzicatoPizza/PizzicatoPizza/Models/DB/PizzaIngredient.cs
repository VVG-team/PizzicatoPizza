using System.ComponentModel.DataAnnotations;

namespace PizzicatoPizza.Models.DB
{
    public class PizzaIngredient
    {
        [Key]
        public int PizzaId { get; set; }

        public Pizza Pizza { get; set; }

        public int IngredientId { get; set; }

        public Ingredient Ingredient { get; set; }

        public int Count { get; set; }

        public decimal Cost { get; set; }
    }
}