using System;
using System.Collections.Generic;

namespace PizzicatoPizza.Models.DB
{
    public class Order
	{
		public int Id { get; set; }

		public DateTime Date { get; set; }

		public User Client { get; set; }

		public Enums.OrderStateEnum State { get; set; }

		public decimal Cost { get; set; }

		public string Address { get; set; }

		public int OrderTime { get; set; }

		public List<Pizza> Pizzas { get; set; }

		public Courier Courier { get; set; }
	}
}

