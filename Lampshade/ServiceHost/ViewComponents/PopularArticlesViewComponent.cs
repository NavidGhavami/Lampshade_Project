using _01_LampshadeQuery.Contracts.Article;
using Microsoft.AspNetCore.Mvc;

namespace ServiceHost.ViewComponents
{
    public class PopularArticlesViewComponent : ViewComponent
    {
        private readonly IArticleQuery _articleQuery;

        public PopularArticlesViewComponent(IArticleQuery articleQuery)
        {
            _articleQuery = articleQuery;
        }

        public IViewComponentResult Invoke()
        {
            var article = _articleQuery.LatestArticles();
            return View(article);
        }
    }
}
