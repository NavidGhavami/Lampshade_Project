﻿using System.Collections.Generic;
using _0_Framework.Application;
using ShopManagement.Application.Contract.Product;
using ShopManagement.Domain.Product;
using ShopManagement.Domain.ProductCategory;

namespace ShopManagement.Application
{
    public class ProductApplication : IProductApplication
    {
        private readonly IProductRepository _productRepository;
        private readonly IFileUploader _fileUploader;
        private readonly IProductCategoryRepository _productCategoryRepository;
        public ProductApplication(IProductRepository productRepository,IFileUploader fileUploader, IProductCategoryRepository productCategoryRepository)
        {
            _productRepository = productRepository;
            _fileUploader = fileUploader;
            _productCategoryRepository = productCategoryRepository;
        }

        public OperationResult Create(CreateProduct command)
        {
            
            var operation = new OperationResult();
            if (_productRepository.Exist(x => x.Name == command.Name))
            {
                return operation.Failed(ApplicationMessages.DuplicatedRecord);
            }
            var slug = command.Slug.Slugify();
            var categorySlug = _productCategoryRepository.GetSlugById(command.CategoryId);
            var picturePath = $"{categorySlug}//{slug}";
            var fileName = _fileUploader.Upload(command.Picture, picturePath);

            var product = new Product(command.Name, command.Code, command.ShortDescription,
                command.Description, fileName, command.PictureAlt, command.PictureTitle,
                slug, command.Keywords, command.MetaDescription, command.CategoryId);
            _productRepository.Create(product);
            _productRepository.SaveChanges();

            return operation.Succedded();
        }

        public OperationResult Edit(EditProduct command)
        {
            var operation = new OperationResult();
            var product = _productRepository.GetProductWithCategory(command.Id);
            if (product == null)
            {
                return operation.Failed(ApplicationMessages.RecordNotFound);
            }

            if (_productRepository.Exist(x => x.Name == command.Name && x.Id != command.Id))
            {
                return operation.Failed(ApplicationMessages.DuplicatedRecord);
            }
            var slug = command.Slug.Slugify();
            var picturePath = $"{product.Category.Slug}/{slug}";
            var fileName = _fileUploader.Upload(command.Picture, picturePath);

            product.Edit(command.Name, command.Code, command.ShortDescription,
                command.Description,fileName, command.PictureAlt, command.PictureTitle,
                slug, command.Keywords, command.MetaDescription, command.CategoryId);
            _productRepository.SaveChanges();

            return operation.Succedded();
        }

        public EditProduct GetDetails(long id)
        {
            return _productRepository.GetDetails(id);
        }

        public List<ProductViewModel> Search(ProductSearchModel searchModel)
        {
            return _productRepository.Search(searchModel);
        }

        public List<ProductViewModel> GetProducts()
        {
            return _productRepository.GetProducts();
        }


    }
}
