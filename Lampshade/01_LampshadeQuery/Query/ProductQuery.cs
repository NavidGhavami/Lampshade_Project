﻿using System;
using System.Collections.Generic;
using System.Linq;
using _0_Framework.Application;
using _01_LampshadeQuery.Contracts.Product;
using CommentManagement.Infrastructure.EFCore;
using DiscountManagement.Infrastructure.EFCore;
using InventoryManagement.Infrastructure.EfCore;
using Microsoft.EntityFrameworkCore;
using ShopManagement.Application.Contract.Order;
using ShopManagement.Domain.ProductPicture;
using ShopManagement.Infrastructure.EFCore;

namespace _01_LampshadeQuery.Query
{
    public class ProductQuery : IProductQueryModel
    {
        private readonly ShopContext _shopContext;
        private readonly InventoryContext _inventoryContext;
        private readonly DiscountContext _discountContext;
        private readonly CommentContext _commentContext;

        public ProductQuery(ShopContext shopContext, InventoryContext inventoryContext,
            DiscountContext discountContext, CommentContext commentContext)
        {
            _shopContext = shopContext;
            _inventoryContext = inventoryContext;
            _discountContext = discountContext;
            _commentContext = commentContext;
        }

        public List<ProductQueryModel> GetLatestProducts()
        {
            var inventory = _inventoryContext.Inventories
                .Select(x => new { x.ProductId, x.UnitPrice });

            var dateTime = DateTime.Now;
            var discounts = _discountContext.CustomerDiscounts
                .Where(x => x.StartDate < dateTime && dateTime < x.EndDate)
                .Select(x => new { x.ProductId, x.DiscountRate });

            var products = _shopContext.Products.Include(x => x.Category)
                .Select(product => new ProductQueryModel
                {
                    Id = product.Id,
                    Category = product.Category.Name,
                    Picture = product.Picture,
                    PictureAlt = product.PictureAlt,
                    PictureTitle = product.PictureTitle,
                    Slug = product.Slug,
                    Name = product.Name,
                }).AsNoTracking().ToList();

            foreach (var product in products)
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

            return products.OrderByDescending(x => x.Id).Take(9).ToList();
        }



        public List<ProductQueryModel> Search(string value)
        {
            var inventory = _inventoryContext.Inventories
                .Select(x => new { x.ProductId, x.UnitPrice });

            var dateTime = DateTime.Now;
            var discounts = _discountContext.CustomerDiscounts
                .Where(x => x.StartDate < dateTime && dateTime < x.EndDate)
                .Select(x => new { x.ProductId, x.DiscountRate });

            var query = _shopContext.Products
                .Include(x => x.Category)
                .Select(product => new ProductQueryModel()
                {
                    Id = product.Id,
                    Category = product.Category.Name,
                    Picture = product.Picture,
                    PictureAlt = product.PictureAlt,
                    PictureTitle = product.PictureTitle,
                    ShortDescription = product.ShortDescription,
                    Slug = product.Slug,
                    Name = product.Name,

                }).AsNoTracking();

            if (!string.IsNullOrWhiteSpace(value))
            {
                query = query.Where(x => x.Name.Contains(value) || x.ShortDescription.Contains(value));
            }

            var products = query.OrderByDescending(x => x.Id).ToList();



            foreach (var product in products)
            {
                var productInventory = inventory.FirstOrDefault(x => x.ProductId == product.Id);
                if (productInventory != null)
                {
                    var price = productInventory.UnitPrice;
                    product.Price = price.ToMoney();
                    var discount = discounts.FirstOrDefault(x => x.ProductId == product.Id);
                    if (discount != null)
                    {
                        var discountRate = discount.DiscountRate;
                        product.DiscountRate = discountRate;
                        //product.DiscountExpireDate = discount.EndDate.ToDiscountFormat();
                        product.HasDiscount = discountRate > 0;
                        var discountAmount = Math.Round((price * discountRate) / 100);
                        product.PriceWithDiscount = (price - discountAmount).ToMoney();
                    }
                }
            }




            return products;
        }

        public ProductQueryModel GetProductDetails(string slug)
        {
            var inventory = _inventoryContext.Inventories
                .Select(x => new { x.ProductId, x.UnitPrice, x.InStock });

            var dateTime = DateTime.Now;

            var discounts = _discountContext.CustomerDiscounts
                .Where(x => x.StartDate < dateTime && dateTime < x.EndDate)
                .Select(x => new { x.ProductId, x.DiscountRate, x.EndDate });

            var products = _shopContext.Products
                .Include(x => x.Category)
                .Include(x => x.ProductPictures)
                .Select(product => new ProductQueryModel
                {
                    Id = product.Id,
                    Category = product.Category.Name,
                    Picture = product.Picture,
                    PictureAlt = product.PictureAlt,
                    PictureTitle = product.PictureTitle,
                    Slug = product.Slug,
                    Name = product.Name,
                    CategorySlug = product.Category.Slug,
                    Code = product.Code,
                    Description = product.Description,
                    Keywords = product.Keywords,
                    MetaDescription = product.MetaDescription,
                    ShortDescription = product.ShortDescription,
                    Pictures = MapProductPictures(product.ProductPictures),


                }).FirstOrDefault(x => x.Slug == slug);

            if (products == null)
            {
                return new ProductQueryModel();
            }

            var productInventory = inventory.FirstOrDefault(x => x.ProductId == products.Id);
            if (productInventory != null)
            {
                products.InStock = productInventory.InStock;
                var price = productInventory.UnitPrice;
                products.Price = price.ToMoney();
                products.DoublePrice = price;

                var discount = discounts.FirstOrDefault(x => x.ProductId == products.Id);
                if (discount != null)
                {
                    var discountRate = discount.DiscountRate;
                    products.DiscountRate = discountRate;
                    products.DiscountExpireDate = discount.EndDate.ToDiscountFormat();
                    products.HasDiscount = discountRate > 0;
                    var discountAmount = Math.Round((price * discountRate) / 100);
                    products.PriceWithDiscount = (price - discountAmount).ToMoney();
                }
            }
            products.Comments = _commentContext.Comments
                .Where(x => x.Type == CommentTypes.Product)
                .Where(x => x.OwnerRecordId == products.Id)
                .Where(x => !x.IsCanceled)
                .Where(x => x.IsConfirmed)
                .Select(x => new CommentQueryModel
                {
                    Id = x.Id,
                    Name = x.Name,
                    Message = x.Message,
                    CreationDate = x.CreationDate.ToFarsi(),


                }).OrderByDescending(x => x.Id).ToList();

            return products;
        }

        public List<CartItem> CheckInventoryStatus(List<CartItem> cartItems)
        {
            var inventory = _inventoryContext.Inventories.ToList();

            foreach (var cartItem in cartItems)
            {
                if (inventory.Any(x => x.ProductId == cartItem.Id && x.InStock))
                {
                    var itemInventory = inventory.Find(x => x.ProductId == cartItem.Id);
                    if (itemInventory != null)
                    {
                        cartItem.IsInStock = itemInventory.CalculateCurrentCount() >= cartItem.Count;
                    }
                }
            }

            return cartItems;
        }


        private static List<ProductPictureQueryModel> MapProductPictures(List<ProductPicture> pictures)
        {
            return pictures.Select(x => new ProductPictureQueryModel
            {
                IsRemoved = x.IsRemoved,
                Picture = x.Picture,
                PictureAlt = x.PictureAlt,
                PictureTitle = x.PictureTitle,
                ProductId = x.ProductId,


            }).Where(x => !x.IsRemoved).ToList();
        }
    }
}