﻿using System;
using System.Collections.Generic;
using System.Linq;
using _0_Framework.Application;
using _01_LampshadeQuery.Contracts.Product;
using _01_LampshadeQuery.Contracts.ProductCategory;
using DiscountManagement.Infrastructure.EFCore;
using InventoryManagement.Infrastructure.EfCore;
using Microsoft.EntityFrameworkCore;
using ShopManagement.Domain.Product;
using ShopManagement.Infrastructure.EFCore;

namespace _01_LampshadeQuery.Query
{
    public class ProductCategoryQuery : IProductCategoryQuery
    {
        private readonly ShopContext _shopContext;
        private readonly InventoryContext _inventoryContext;
        private readonly DiscountContext _discountContext;

        public ProductCategoryQuery(ShopContext shopContext, InventoryContext inventoryContext, DiscountContext discountContext)
        {
            _shopContext = shopContext;
            _inventoryContext = inventoryContext;
            _discountContext = discountContext;
        }

        public List<ProductCategoryQueryModel> GetProductCategory()
        {
            return _shopContext.ProductCategories.Select(x => new ProductCategoryQueryModel
            {
                Id = x.Id,
                Name = x.Name,
                Description = x.Description,
                Picture = x.Picture,
                PictureAlt = x.PictureAlt,
                PictureTitle = x.PictureTitle,
                Slug = x.Slug

            }).ToList();
        }

        public List<ProductCategoryQueryModel> GetProductCategoriesWithProducts()
        {
            var inventory = _inventoryContext.Inventories
                .Select(x => new { x.ProductId, x.UnitPrice });

            var dateTime = DateTime.Now;
            var discounts = _discountContext.CustomerDiscounts
                .Where(x => x.StartDate < dateTime && dateTime < x.EndDate)
                .Select(x => new { x.ProductId, x.DiscountRate });

            var categories = _shopContext.ProductCategories
                .Include(x => x.Products)
                .ThenInclude(x => x.Category)
                .Select(x => new ProductCategoryQueryModel
                {
                    Id = x.Id,
                    Name = x.Name,
                    Products = MapProducts(x.Products)

                }).ToList();

            foreach (var category in categories)
            {
                foreach (var product in category.Products)
                {
                    var price = inventory.FirstOrDefault(x => x.ProductId == product.Id)
                        .UnitPrice;
                    product.Price = price.ToMoney();



                    var discount = discounts.FirstOrDefault(x => x.ProductId == product.Id);
                    if (discount != null)
                    {
                        int discountRate = discount.DiscountRate;
                        product.DiscountRate = discountRate;
                        product.HasDiscount = discountRate > 0;

                        var discountAmount = Math.Round((price * discountRate) / 100);
                        product.PriceWithDiscount = (price - discountAmount).ToMoney();
                    }


                }
            }


            return categories;
        }

        public ProductCategoryQueryModel GetProductCategoryWithProductsBy(string slug)
        {
            var inventory = _inventoryContext.Inventories
                .Select(x => new { x.ProductId, x.UnitPrice });

            var dateTime = DateTime.Now;
            var discounts = _discountContext.CustomerDiscounts
                .Where(x => x.StartDate < dateTime && dateTime < x.EndDate)
                .Select(x => new { x.ProductId, x.DiscountRate });

            var category = _shopContext.ProductCategories
                .Include(a => a.Products)
                .ThenInclude(x => x.Category)
                .Select(x => new ProductCategoryQueryModel
                {
                    Id = x.Id,
                    Name = x.Name,
                    Description = x.Description,
                    MetaDescription = x.MetaDescription,
                    Keywords = x.Keywords,
                    Slug = x.Slug,
                    Products = MapProducts(x.Products)

                }).AsNoTracking().FirstOrDefault(x => x.Slug == slug);


            if (category != null)
            {
                foreach (var product in category.Products)
                {
                    var productInventory = inventory.FirstOrDefault(x => x.ProductId == product.Id);
                    if (productInventory != null)
                    {
                        var price = productInventory.UnitPrice;
                        product.Price = price.ToMoney();
                        var discount = discounts.FirstOrDefault(x => x.ProductId == product.Id);
                        if (discount != null)
                        {
                            int discountRate = discount.DiscountRate;
                            product.DiscountRate = discountRate;
                            //product.DiscountExpireDate = discount.EndDate.ToDiscountFormat();
                            product.HasDiscount = discountRate > 0;
                            var discountAmount = Math.Round((price * discountRate) / 100);
                            product.PriceWithDiscount = (price - discountAmount).ToMoney();
                        }
                    }
                }



            }
            return category;
        }

        private static List<ProductQueryModel> MapProducts(List<Product> products)
        {
            return products.Select(product => new ProductQueryModel
            {
                Id = product.Id,
                Category = product.Category.Name,
                Picture = product.Picture,
                PictureAlt = product.PictureAlt,
                PictureTitle = product.PictureTitle,
                Slug = product.Slug,
                Name = product.Name,
            }).ToList();


        }
    }
}
