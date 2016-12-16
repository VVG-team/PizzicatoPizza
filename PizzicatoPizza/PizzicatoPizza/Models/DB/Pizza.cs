﻿namespace PizzicatoPizza.Models.DB
{
    public class Pizza
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public decimal Cost { get; set; }

        public int Weight { get; set; }

        public string Image { get; set; }

        public Size Size { get; set; }
    }
}