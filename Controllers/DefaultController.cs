using Microsoft.AspNet.Mvc;

namespace JsDesignPatternsGettingStarted.Controllers
{
    public class DefaultController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
