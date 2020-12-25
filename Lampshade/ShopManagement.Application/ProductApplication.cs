using System.Collections.Generic;
using _0_Framework.Application;
using ShopManagement.Application.Contract.Product;
using ShopManagement.Domain.Product;

namespace ShopManagement.Application
{
    public class ProductApplication:IProductApplication
    {
        private readonly IProductRepository _productRepository;

        public ProductApplication(IProductRepository productRepository)
        {
            _productRepository = productRepository;
        }

        public OperationResult Create(CreateProduct command)
        {
            var slug = command.Slug.Slugify();
            var operation = new OperationResult();
            if (_productRepository.Exist(x=>x.Name==command.Name))
            {
                return operation.Failed(ApplicationMessages.DuplicatedRecord);
            }
            var product = new Product(command.Name,command.Code,command.UnitPrice,command.ShortDescription,
                command.Description,command.Picture,command.PictureAlt,command.PictureTitle,
                slug, command.Keywords,command.MetaDescription,command.CategoryId);
            _productRepository.Create(product);
            _productRepository.SaveChanges();

            return operation.Succedded();
        }

        public OperationResult Edit(EditProduct command)
        {
            var slug = command.Slug.Slugify();
            var operation = new OperationResult();
            var product = _productRepository.Get(command.Id);
            if (product==null)
            {
                return operation.Failed(ApplicationMessages.RecordNotFound);
            }

            if (_productRepository.Exist(x=>x.Name == command.Name && x.Id!=command.Id))
            {
                return operation.Failed(ApplicationMessages.DuplicatedRecord);
            }
            product.Edit(command.Name, command.Code, command.UnitPrice, command.ShortDescription,
                command.Description, command.Picture, command.PictureAlt, command.PictureTitle,
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

        public OperationResult InStock(long id)
        {
            
            var operation = new OperationResult();
            var product = _productRepository.Get(id);
            if (product == null)
            {
                return operation.Failed(ApplicationMessages.RecordNotFound);
            }

            product.InStock();
            _productRepository.SaveChanges();

            return operation.Succedded();
        }

        public OperationResult NotInStock(long id)
        {

            var operation = new OperationResult();
            var product = _productRepository.Get(id);
            if (product == null)
            {
                return operation.Failed(ApplicationMessages.RecordNotFound);
            }

            product.NotInStock();
            _productRepository.SaveChanges();

            return operation.Succedded();
        }
    }
}
