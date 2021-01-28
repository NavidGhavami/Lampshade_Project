using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using _01_LampshadeQuery.Contracts.Cart;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Nancy.Json;
using ShopManagement.Application.Contract.Order;

namespace ServiceHost.Pages
{
    public class CheckoutModel : PageModel
    {
        public Cart Cart;
        public const string CookieName = "cart-items";
        private readonly ICartCalculatorService _cartCalculatorService;

        public CheckoutModel(ICartCalculatorService calculatorService)
        {
            _cartCalculatorService = calculatorService;
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

            Cart = _cartCalculatorService.ComputeCart(cartItems);


        }
    }
}
