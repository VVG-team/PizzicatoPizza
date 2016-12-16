using PizzicatoPizza.Models.DB;
using PizzicatoPizza.Models.Enums;
using System;

namespace PizzicatoPizza.Models.DTO
{
    public class OrderDTO
    {
        public int Id { get; set; }

        public DateTime Date { get; set; }

        public OrderStateEnum State { get; set; }

        public decimal Cost { get; set; }

        public string Address { get; set; }

        public int OrderTime { get; set; }

        public User Client { get; set; }

        public Courier Courier { get; set; }
    }
}

