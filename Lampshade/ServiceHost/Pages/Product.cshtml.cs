using System.Net.Http.Headers;
using _01_LampshadeQuery.Contracts.Product;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using ShopManagement.Application.Contract.Comment;
using ShopManagement.Application.Contract.Product;

namespace ServiceHost.Pages
{
    public class ProductModel : PageModel
    {
        public ProductQueryModel Product;
        private readonly IProductQueryModel _productQuery;
        private readonly ICommentApplication _commentApplication;

        public ProductModel(IProductQueryModel productQuery, ICommentApplication commentApplication)
        {
            _productQuery = productQuery;
            _commentApplication = commentApplication;
        }


        public void OnGet(string id)
        {
            Product = _productQuery.GetDetailsBy(id);
        }

        public IActionResult OnPost(AddComment command , string productSlug)
        {
            var result = _commentApplication.Add(command);
            return RedirectToPage("./Product", new {id = productSlug});
        }
    }
}
