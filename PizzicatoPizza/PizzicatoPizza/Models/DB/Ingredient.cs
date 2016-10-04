namespace PizzicatoPizza.Models.DB
{
    public class Ingredient
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public decimal Price { get; set; }

        public int Weight { get; set; }

        public string Image { get; set; }

        public Enums.CategoryEnum Category { get; set; }
    }
}