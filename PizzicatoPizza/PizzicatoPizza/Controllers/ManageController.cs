using PizzicatoPizza.BAL.Interfaces;
using PizzicatoPizza.Models.DB;
using System.Web.Mvc;

namespace PizzicatoPizza.Controllers
{
    public class ManageController : Controller
    {
        private IPizzaManager pizzaManager;

        public ManageController(IPizzaManager pizzaManager)
        {
            this.pizzaManager = pizzaManager;
        }

        public ActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public JsonResult GetPizzas()
        {
            var pizzas = pizzaManager.GetPizzas();
            return Json(pizzas, JsonRequestBehavior.AllowGet);
        }

        [HttpPost]
        public JsonResult DeletePizza(int Id)
        {
            pizzaManager.DeletePizza(Id);
            return Json(new { });
        }

        [HttpPost]
        public JsonResult UpdatePizza(Pizza pizza)
        {
            pizzaManager.UpdatePizza(pizza);
            return Json(new { });
        }
    }
}