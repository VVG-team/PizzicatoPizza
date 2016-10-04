using System;
using System.Collections.Generic;

namespace PizzicatoPizza.Models.DTO
{
    public class OrderDTO
    {
		public int Id { get; set; }

		public DateTime Date { get; set; }

		public UserDTO Client { get; set; }

		public Enums.OrderStateEnum State { get; set; }

		public decimal Cost { get; set; }

		public string Address { get; set; }

		public int OrderTime { get; set; }

		public List<PizzaDTO> Pizzas { get; set; }

		public CourierDTO Courier { get; set; }
	}
}

