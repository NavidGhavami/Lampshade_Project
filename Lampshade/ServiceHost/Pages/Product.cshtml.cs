using System.Net.Http.Headers;
using _01_LampshadeQuery.Contracts.Product;
using Microsoft.AspNetCore.Mvc.RazorPages;
using ShopManagement.Application.Contract.Product;

namespace ServiceHost.Pages
{
    public class ProductModel : PageModel
    {
        public ProductQueryModel Product;
        private readonly IProductQueryModel _productQuery;

        public ProductModel(IProductQueryModel productQuery)
        {
            _productQuery = productQuery;
        }


        public void OnGet(string id)
        {
            Product = _productQuery.GetDetailsBy(id);
        }
    }
}
