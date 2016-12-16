using PizzicatoPizza.Models.Enums;

namespace PizzicatoPizza.Models.DTO
{
    public class IngredientDTO
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public decimal Price { get; set; }

        public int Weight { get; set; }

        public string Image { get; set; }

        public CategoryEnum Category { get; set; }
    }
}