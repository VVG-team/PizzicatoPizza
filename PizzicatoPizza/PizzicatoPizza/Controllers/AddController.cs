using PizzicatoPizza.BAL.Interfaces;
using PizzicatoPizza.Models.DB;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace PizzicatoPizza.Controllers
{
    public class AddController : Controller
    {

        private IPizzaManager pizzaManager;

        public AddController(IPizzaManager pizzaManager)
        {
            this.pizzaManager = pizzaManager;
        }

        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public JsonResult AddPizza(Pizza pizza)
        {
            pizzaManager.AddPizza(pizza);
            return Json(new { });
        }
    }
}