using Microsoft.AspNetCore.Mvc;

namespace AkademiPlusEdukator.PresentationLayer.ViewComponents.Default
{
    public class _ScriptPartial:ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
