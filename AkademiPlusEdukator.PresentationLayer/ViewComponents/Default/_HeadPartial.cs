using Microsoft.AspNetCore.Mvc;

namespace AkademiPlusEdukator.PresentationLayer.ViewComponents.Default
{
    public class _HeadPartial : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}