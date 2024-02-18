using HomeWork1.Models;
using System.Linq;
using System.Web.Mvc;

namespace HomeWork1.Controllers
{
    public class RestaurantController : Controller
    {
        MyDbContext db = new MyDbContext();

        [HttpGet]
        public ActionResult Index()
        {
            return View(db.Restaurants.ToList());
        }
    }
}