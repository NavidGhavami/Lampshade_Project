using System.Collections.Generic;
using _01_LampshadeQuery.Contracts.Product;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace ServiceHost.Pages
{
    public class SearchModel : PageModel
    {
        public string Value;
        public List<ProductQueryModel> Product;
        private readonly IProductQueryModel _productQuery;

        public SearchModel(IProductQueryModel productQuery)
        {
            _productQuery = productQuery;
        }

        public void OnGet(string value)
        {
            Value = value;
            Product = _productQuery.Search(value);
        }
    }
}
