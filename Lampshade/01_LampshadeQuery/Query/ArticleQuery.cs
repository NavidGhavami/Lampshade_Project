using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using _0_Framework.Application;
using _01_LampshadeQuery.Contracts.Article;
using BlogManagement.Infrastructure.EFCore;
using Microsoft.EntityFrameworkCore;

namespace _01_LampshadeQuery.Query
{
    public class ArticleQuery : IArticleQuery
    {
        private readonly BlogContext _blogContext;

        public ArticleQuery(BlogContext blogContext)
        {
            _blogContext = blogContext;
        }

        public List<ArticleQueryModel> LatestArticles()
        {
            var Date = DateTime.Now;
            return _blogContext.Articles
                .Include(x=>x.ArticleCategory)
                .Where(x => x.PublishDate <= Date)
                .Select(x => new ArticleQueryModel
            {
                Title = x.Title,
                CategoryName = x.ArticleCategory.Name,
                CategorySlug = x.ArticleCategory.Slug,
                Picture = x.Picture,
                PictureAlt = x.PictureAlt,
                PictureTitle = x.PictureTitle,
                Slug = x.Slug,
                ShortDescription = x.ShortDescription,
                PublishDate = x.PublishDate.ToFarsi(),
                

            }).ToList();
        }

        public ArticleQueryModel GetArticleDetails(string slug)
        {
            var Date = DateTime.Now;
            var article =  _blogContext.Articles
                .Include(x => x.ArticleCategory)
                .Where(x => x.PublishDate <= Date)
                .Select(x => new ArticleQueryModel
                {
                    Title = x.Title,
                    CategoryName = x.ArticleCategory.Name,
                    CategorySlug = x.ArticleCategory.Slug,
                    Picture = x.Picture,
                    PictureAlt = x.PictureAlt,
                    PictureTitle = x.PictureTitle,
                    Slug = x.Slug,
                    CanonicalAddress = x.CanonicalAddress,
                    Description = x.Description,
                    ShortDescription = x.ShortDescription,
                    MetaDescription = x.MetaDescription,
                    Keywords = x.Keywords,
                    PublishDate = x.PublishDate.ToFarsi(),


                }).FirstOrDefault(x => x.Slug == slug);

            article.KeywordList = article.Keywords.Split(".").ToList();

            return article;
        }
    }
}
