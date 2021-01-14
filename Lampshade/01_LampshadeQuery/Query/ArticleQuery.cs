using System;
using System.Collections.Generic;
using System.Linq;
using _0_Framework.Application;
using _01_LampshadeQuery.Contracts.Article;
using _01_LampshadeQuery.Contracts.Product;
using BlogManagement.Infrastructure.EFCore;
using CommentManagement.Infrastructure.EFCore;
using Microsoft.EntityFrameworkCore;

namespace _01_LampshadeQuery.Query
{
    public class ArticleQuery : IArticleQuery
    {
        private readonly BlogContext _blogContext;
        private readonly CommentContext _commentContext;

        public ArticleQuery(BlogContext blogContext, CommentContext commentContext)
        {
            _blogContext = blogContext;
            _commentContext = commentContext;
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
            var date = DateTime.Now;
            var article =  _blogContext.Articles
                .Include(x => x.ArticleCategory)
                .Where(x => x.PublishDate <= date)
                .Select(x => new ArticleQueryModel
                {
                    Id =x.Id,
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


            var comments = _commentContext.Comments
                .Where(x => x.Type == CommentTypes.Article)
                .Where(x => x.OwnerRecordId == article.Id)
                .Where(x => !x.IsCanceled)
                .Where(x => x.IsConfirmed)
                .Select(x => new CommentQueryModel
                {
                    Id = x.Id,
                    Name = x.Name,
                    Message = x.Message,
                    CreationDate = x.CreationDate.ToFarsi(),
                    ParentId = x.ParentId,


                }).OrderByDescending(x => x.Id).ToList();

            foreach (var comment in comments)
            {
                if (comment.ParentId > 0)
                {
                    comment.ParentName = comments.FirstOrDefault(x => x.Id == comment.ParentId).Name;
                }
            }

            article.Comments = comments;
            return article;
        }
    }
}
