using Microsoft.AspNetCore.Mvc;

namespace AkademiPlusEdukator.PresentationLayer.Controllers
{
    public class AdminLayoutController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
