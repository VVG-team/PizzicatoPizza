using PizzicatoPizza.BAL.Interfaces;
using System.Web.Mvc;

namespace PizzicatoPizza.Controllers
{
    public class HomeController : Controller
	{
        private IPizzaManager pizzaManager;

        public HomeController(IPizzaManager pizzaManager)
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
	}
}