using HomeWork1.Models;
using System.Linq;
using System.Web.Mvc;

namespace HomeWork1.Controllers
{
    public class CountryController : Controller
    {
        MyDbContext db = new MyDbContext();

        [HttpGet]
        public ActionResult Index()
        {
            return View(db.Countries.ToList());
        }
    }
}