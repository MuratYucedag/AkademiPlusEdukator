using Microsoft.AspNetCore.Mvc;

namespace AkademiPlusEdukator.PresentationLayer.ViewComponents.Default
{
    public class _FooterPartial:ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
