using Microsoft.AspNetCore.Mvc;

namespace ServiceHost.ViewComponents
{
    public class SmallBannerViewComponent : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
