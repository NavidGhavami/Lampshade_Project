using Microsoft.AspNetCore.Mvc;

namespace ServiceHost.ViewComponents
{
    public class CommentViewComponent : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
