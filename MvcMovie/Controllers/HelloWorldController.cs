using System.Web;
using System.Web.Mvc;

namespace MvcMovie.Controllers
{
    public class HelloWorldController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Welcome(string name, int numTimes = 1)
        {
            ViewBag.Greeting = "Hello, ";
            ViewBag.Person = name;
            ViewBag.NumTimes = numTimes;

            return View();
        }
    }
}