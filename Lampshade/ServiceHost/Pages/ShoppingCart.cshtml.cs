using System;
using System.Collections.Generic;
using System.Linq;
using _01_LampshadeQuery.Contracts.Product;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Nancy.Json;
using ShopManagement.Application.Contract.Order;

namespace ServiceHost.Pages
{
    public class ShoppingCartModel : PageModel
    {
        public List<CartItem> CartItems;
        public const string CookieName = "cart-items";
        private readonly IProductQueryModel _productQuery;

        public ShoppingCartModel(IProductQueryModel productQuery)
        {
            CartItems = new List<CartItem>();
            _productQuery = productQuery;
        }

        public void OnGet()
        {
            var serializer = new JavaScriptSerializer();
            var value = Request.Cookies[CookieName];
            var cartItems = serializer.Deserialize<List<CartItem>>(value);

            foreach (var item in cartItems)
            {
                item.CalculateTotalItemPrice();
            }

            CartItems = _productQuery.CheckInventoryStatus(cartItems);
        }

        public IActionResult OnGetRemoveFromCart(long id)
        {
            var serializer = new JavaScriptSerializer();
            var value = Request.Cookies[CookieName];
            Response.Cookies.Delete(CookieName);
            var cartItems = serializer.Deserialize<List<CartItem>>(value);
            var itemToRemove = cartItems.FirstOrDefault(x => x.Id == id);
            cartItems.Remove(itemToRemove);
            var options = new CookieOptions { Expires = DateTime.Now.AddDays(2) };
            Response.Cookies.Append(CookieName, serializer.Serialize(cartItems), options);

            return RedirectToPage("/ShoppingCart");
        }

        public IActionResult OnGetGoToCheckout()
        {
            var serializer = new JavaScriptSerializer();
            var value = Request.Cookies[CookieName];
            var cartItems = serializer.Deserialize<List<CartItem>>(value);

            foreach (var item in cartItems)
            {
                item.CalculateTotalItemPrice();
            }

            CartItems = _productQuery.CheckInventoryStatus(cartItems);
            return RedirectToPage(CartItems.Any(x=>!x.IsInStock) ? "/ShoppingCart" : "/Checkout");
        }
    }
}
