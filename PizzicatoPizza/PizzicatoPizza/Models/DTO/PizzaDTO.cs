using System.Collections.Generic;

namespace PizzicatoPizza.Models.DTO
{
    public class PizzaDTO
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public SizeDTO Size { get; set; }

        public List<IngredientDTO> Ingredients { get; set; }

        public decimal Cost { get; set; }

        public int Weight { get; set; }

        public string Image { get; set; }

        public int Count { get; set; }
    }
}