using _01_LampshadeQuery.Contracts.Product;
using Microsoft.AspNetCore.Mvc;

namespace ServiceHost.ViewComponents
{
    public class LatestProductsViewComponent : ViewComponent
    {
        private readonly IProductQueryModel _productQueryModel;

        public LatestProductsViewComponent(IProductQueryModel productQueryModel)
        {
            _productQueryModel = productQueryModel;
        }

        public IViewComponentResult Invoke()
        {
            var product = _productQueryModel.GetLatestProducts();
            return View(product);
        }
    }
}
