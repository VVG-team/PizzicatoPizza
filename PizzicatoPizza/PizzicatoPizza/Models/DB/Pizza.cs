using System.Collections.Generic;

namespace PizzicatoPizza.Models.DB
{
    public class Pizza
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public Size Size { get; set; }

        public List<Ingredient> Ingredients { get; set; }

        public decimal Cost { get; set; }

        public int Weight { get; set; }

        public string Image { get; set; }

        public int Count { get; set; }
    }
}