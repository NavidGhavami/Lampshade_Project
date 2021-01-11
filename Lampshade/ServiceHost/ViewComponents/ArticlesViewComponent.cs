using Microsoft.AspNetCore.Mvc;

namespace ServiceHost.ViewComponents
{
    public class ArticlesViewComponent : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
