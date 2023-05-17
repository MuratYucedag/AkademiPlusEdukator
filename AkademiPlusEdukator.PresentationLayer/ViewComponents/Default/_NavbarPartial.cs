using Microsoft.AspNetCore.Mvc;

namespace AkademiPlusEdukator.PresentationLayer.ViewComponents.Default
{
    public class _NavbarPartial : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
