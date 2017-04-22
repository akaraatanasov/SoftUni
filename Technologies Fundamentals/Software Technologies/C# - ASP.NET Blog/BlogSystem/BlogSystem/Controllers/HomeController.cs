using System.Web.Mvc;

namespace BlogSystem.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return RedirectToAction("List", "Article");
        }
    }
}