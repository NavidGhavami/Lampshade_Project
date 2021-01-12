using System.Collections.Generic;
using _01_LampshadeQuery.Contracts.Article;
using _01_LampshadeQuery.Contracts.ArticleCategory;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace ServiceHost.Pages
{
    public class ArticleDetailsModel : PageModel
    {
        public ArticleQueryModel Article;
        public List<ArticleCategoryQueryModel> ArticleCategory;

        private readonly IArticleQuery _articleQuery;
        private readonly IArticleCategoryQuery _articleCategoryQuery;


        public ArticleDetailsModel(IArticleQuery articleQuery,IArticleCategoryQuery articleCategoryQuery)
        {
            _articleQuery = articleQuery;
            _articleCategoryQuery = articleCategoryQuery;
        }

        public void OnGet(string id)
        {
            ArticleCategory = _articleCategoryQuery.GetArticleCategories();
            Article = _articleQuery.GetArticleDetails(id);
        }
    }
}
