﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using _0_Framework.Infrastructure;
using Microsoft.EntityFrameworkCore;
using ShopManagement.Application.Contract.Product;
using ShopManagement.Domain.Product;

namespace ShopManagement.Infrastructure.EFCore.Repository
{
    public class ProductRepository:RepositoryBase<long , Product>,IProductRepository
    {
        private readonly ShopContext _context;

        public ProductRepository( ShopContext context) : base(context)
        {
            _context = context;
        }

        public List<ProductViewModel> Search(ProductSearchModel searchModel)
        {
            var query = _context.Products
                .Include(x => x.Category)
                .Select(x => new ProductViewModel
                {
                    Id = x.Id,
                    Name = x.Name,
                    Code = x.Code,
                    UnitPrice = x.UnitPrice,
                    Category = x.Category.Name,
                    CategoryId = x.CategoryId,
                    Picture = x.Picture,
                    CreationDate = x.CreationDate.ToString(),
                    IsInStock = x.IsInStock
                    
                });

            if (!string.IsNullOrWhiteSpace(searchModel.Name))
            {
                query = query.Where(x => x.Name.Contains(searchModel.Name));
            }
            if (!string.IsNullOrWhiteSpace(searchModel.Code))
            {
                query = query.Where(x => x.Code.Contains(searchModel.Code));
            }
            if (searchModel.CategoryId!=0)
            {
                query = query.Where(x => x.CategoryId == searchModel.CategoryId);
            }

            return query.OrderByDescending(x => x.Id).ToList();
        }

        public EditProduct GetDetails(long id)
        {
            return _context.Products
                .Select(x => new EditProduct
                {
                    Id=x.Id,
                    Name = x.Name,
                    Code = x.Code,
                    Slug = x.Slug,
                    UnitPrice=x.UnitPrice,
                    CategoryId = x.CategoryId,
                    Description = x.Description,
                    ShortDescription = x.ShortDescription,
                    Keywords = x.Keywords,
                    MetaDescription = x.MetaDescription,
                    Picture = x.Picture,
                    PictureAlt = x.PictureAlt,
                    PictureTitle = x.PictureTitle
                    
                    


                }).FirstOrDefault(x => x.Id == id);


        }

        public List<ProductViewModel> GetProducts()
        {
            return _context.Products.Select(x => new ProductViewModel
            {
                Id=x.Id,
                Name = x.Name

            }).ToList();
        }
    }
}
