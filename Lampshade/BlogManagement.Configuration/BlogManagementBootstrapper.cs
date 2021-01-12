﻿using BlogManagement.Application;
using BlogManagement.Application.Contract.Article;
using BlogManagement.Application.Contract.ArticleCategory;
using BlogManagement.Domain.Article;
using BlogManagement.Domain.ArticleCategory;
using BlogManagement.Infrastructure.EFCore;
using BlogManagement.Infrastructure.EFCore.Repository;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

namespace BlogManagement.Configuration
{
    public class BlogManagementBootstrapper
    {
        public static void Configure(IServiceCollection services, string connectionString)
        {
            services.AddTransient<IArticleCategoryApplication, ArticleCategoryApplication>();
            services.AddTransient<IArticleCategoryRepository, ArticleCategoryRepository>();

            services.AddTransient<IArticleRepository, ArticleRepository>();
            services.AddTransient<IArticleApplication, ArticleApplication>();

            services.AddDbContext<BlogContext>(x=>x.UseSqlServer(connectionString));
        }
    }
}
