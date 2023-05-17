using Microsoft.AspNetCore.Mvc;

namespace AkademiPlusEdukator.PresentationLayer.Controllers
{
    public class DefaultController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
