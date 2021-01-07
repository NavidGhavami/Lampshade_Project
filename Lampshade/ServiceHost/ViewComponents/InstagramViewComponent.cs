using Microsoft.AspNetCore.Mvc;

namespace ServiceHost.ViewComponents
{
    public class InstagramViewComponent : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
