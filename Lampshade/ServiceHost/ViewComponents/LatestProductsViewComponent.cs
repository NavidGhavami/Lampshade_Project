using _01_LampshadeQuery.Contracts.Product;
using Microsoft.AspNetCore.Mvc;

namespace ServiceHost.ViewComponents
{
    public class LatestProductsViewComponent : ViewComponent
    {
        private readonly IProductQueryModel _productQuery;

        public LatestProductsViewComponent(IProductQueryModel productQuery)
        {
            _productQuery = productQuery;
        }

        public IViewComponentResult Invoke()
        {
            var product = _productQuery.GetLatestProducts();
            return View(product);
        }
    }
}
