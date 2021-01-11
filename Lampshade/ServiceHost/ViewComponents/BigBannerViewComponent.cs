using Microsoft.AspNetCore.Mvc;

namespace ServiceHost.ViewComponents
{
    public class BigBannerViewComponent : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
