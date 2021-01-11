﻿using System.Collections.Generic;
using System.Linq;
using _0_Framework.Application;
using _0_Framework.Domain;
using _0_Framework.Infrastructure;
using BlogManagement.Application.Contract.ArticleCategory;
using BlogManagement.Domain.ArticleCategory;
using Microsoft.EntityFrameworkCore;
using Microsoft.IdentityModel.Tokens;

namespace BlogManagement.Infrastructure.EFCore.Repository
{
    public class ArticleCategoryRepository : RepositoryBase<long, ArticleCategory>, IArticleCategoryRepository
    {
        private readonly BlogContext _blogContext;
        public ArticleCategoryRepository(BlogContext blogContext) : base(blogContext)
        {
            _blogContext = blogContext;
        }


        public List<ArticleCategoryViewModel> Search(ArticleCategorySearchModel searchModel)
        {
            var query = _blogContext.ArticleCategories.Select(x => new ArticleCategoryViewModel
            {
                Id = x.Id,
                Name = x.Name,
                ShowOrder = x.ShowOrder,
                Picture = x.Picture,
                ShortDescription = x.ShortDescription,
                CreationDate = x.CreationDate.ToFarsi(),
                
            });

            if (!string.IsNullOrWhiteSpace(searchModel.Name))
            {
                query = query.Where(x => x.Name.Contains(searchModel.Name));
            }

            return query.OrderByDescending(x => x.ShowOrder).ToList();
        }

        public EditArticleCategory GetDetails(long id)
        {
            return _blogContext.ArticleCategories.Select(x => new EditArticleCategory
            {
                Id = x.Id,
                Name = x.Name,
                ShortDescription = x.ShortDescription,
                Description = x.Description,
                CanonicalAddress = x.CanonicalAddress,
                Keywords = x.Keywords,
                MetaDescription = x.MetaDescription,
                ShowOrder = x.ShowOrder,
                Slug = x.Slug,
                PictureAlt = x.PictureAlt,
                PictureTitle = x.PictureTitle

            }).FirstOrDefault(x => x.Id == id);
        }


    }
}
