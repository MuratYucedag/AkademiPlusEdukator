using Microsoft.AspNetCore.Mvc;

namespace AkademiPlusEdukator.PresentationLayer.ViewComponents.Default
{
    public class _BottomGridPartial:ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
