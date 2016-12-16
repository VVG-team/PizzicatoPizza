using System;
using System.Collections.Generic;
using DAL.Interface;
using PizzicatoPizza.BAL.Interfaces;
using PizzicatoPizza.Models.DB;
using System.Linq;

namespace PizzicatoPizza.BAL.Managers
{
    public class PizzaManager : IPizzaManager
    {
        public IUnitOfWork uOW;

        public PizzaManager(IUnitOfWork uOW)
        {
            this.uOW = uOW;
        }

        public void AddPizza(Pizza pizza)
        {
            uOW.PizzaRepo.Insert(pizza);
            uOW.Save();
        }

        public void DeletePizza(int id)
        {
            uOW.PizzaRepo.Delete(id);
            uOW.Save();
        }

        public List<Pizza> GetPizzas()
        {
            return uOW.PizzaRepo.All.ToList();
        }

        public void UpdatePizza(Pizza pizza)
        {
            uOW.PizzaRepo.Update(pizza);
            uOW.Save();
        }
    }
}