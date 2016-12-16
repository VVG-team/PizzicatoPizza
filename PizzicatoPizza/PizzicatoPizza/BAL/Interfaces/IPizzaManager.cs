using PizzicatoPizza.Models.DB;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PizzicatoPizza.BAL.Interfaces
{
    public interface IPizzaManager
    {
        List<Pizza> GetPizzas();
        void DeletePizza(int id);
        void UpdatePizza(Pizza pizza);
        void AddPizza(Pizza pizza);
    }
}