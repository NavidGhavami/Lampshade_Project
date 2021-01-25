using System.Collections.Generic;
using _0_Framework.Application;
using _0_Framework.Infrastructure;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using ShopManagement.Application.Contract.Product;
using ShopManagement.Application.Contract.ProductCategory;
using ShopManagement.Configuration.Permissions;

namespace ServiceHost.Areas.Adminstration.Pages.Shop.Products
{
    public class IndexModel : PageModel
    {
        [TempData] public string Message { get; set; }

        public ProductSearchModel SearchModel;
        public List<ProductViewModel> Product;
        private readonly IProductApplication _productApplication;
        public SelectList ProductCategory;
        private readonly IProductCategoryApplication _productCategoryApplication;

        public IndexModel(IProductApplication productApplication,
            IProductCategoryApplication productCategoryApplication)
        {
            _productApplication = productApplication;
            _productCategoryApplication = productCategoryApplication;
        }

        [NeedPermission(ShopPermission.ListProducts)]
        public void OnGet(ProductSearchModel searchModel)
        {
            ProductCategory = new SelectList(_productCategoryApplication.GetProductCategory(), "Id", "Name");
            Product = _productApplication.Search(searchModel);
        }

        public IActionResult OnGetCreate()
        {
            var command = new CreateProduct
            {
                Category = _productCategoryApplication.GetProductCategory()
            };

            return Partial("./Create", command);
        }

        [NeedPermission(ShopPermission.CreateProducts)]
        public JsonResult OnPostCreate(CreateProduct command)
        {
            var result = _productApplication.Create(command);
            return new JsonResult(result);
        }

        public IActionResult OnGetEdit(long id)
        {
            var product = _productApplication.GetDetails(id);
            product.Category = _productCategoryApplication.GetProductCategory();
            return Partial("Edit", product);
        }

        [NeedPermission(ShopPermission.EditProducts)]
        public JsonResult OnPostEdit(EditProduct command)
        {
            var result = _productApplication.Edit(command);
            return new JsonResult(result);
        }
    }
}
