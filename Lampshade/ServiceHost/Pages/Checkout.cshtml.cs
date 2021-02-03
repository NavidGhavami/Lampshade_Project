using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using _0_Framework.Application;
using _0_Framework.Application.ZarinPal;
using _01_LampshadeQuery.Contracts.Cart;
using _01_LampshadeQuery.Contracts.Product;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Nancy.Json;
using ShopManagement.Application.Contract.Order;

namespace ServiceHost.Pages
{
    [Authorize]
    public class CheckoutModel : PageModel
    {
        public Cart Cart;
        public const string CookieName = "cart-items";
        private readonly ICartCalculatorService _cartCalculatorService;
        private readonly ICartService _cartService;
        private readonly IProductQueryModel _productQuery;
        private readonly IOrderApplication _orderApplication;
        private readonly IZarinPalFactory _zarinPalFactory;
        private readonly IAuthHelper _authHelper;
        public CheckoutModel(ICartCalculatorService calculatorService, ICartService cartService,
            IProductQueryModel productQuery, IOrderApplication orderApplication, IZarinPalFactory zarinPalFactory, IAuthHelper authHelper)
        {
            _cartCalculatorService = calculatorService;
            _cartService = cartService;
            _productQuery = productQuery;
            _orderApplication = orderApplication;
            _zarinPalFactory = zarinPalFactory;
            _authHelper = authHelper;

            Cart = new Cart();
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

            _cartService.Set(Cart);

        }

        public IActionResult OnGetPay()
        {
            var cart = _cartService.Get();
            var result = _productQuery.CheckInventoryStatus(cart.Items);
            if (result.Any(x => !x.IsInStock))
            {
                return RedirectToPage("/Cart");
            }

            var orderId = _orderApplication.PlaceOrder(cart);
            var paymentResponse = _zarinPalFactory.CreatePaymentRequest(

                cart.PayAmount.ToString(CultureInfo.InvariantCulture),
                "",
                "",
                "خرید از فروشگاه دکومال",
                orderId
                );

            return Redirect($"https://{_zarinPalFactory.Prefix}.zarinpal.com/pg/StartPay/{paymentResponse.Authority}");

        }

        public IActionResult OnGetCallBack([FromQuery] string authority, [FromQuery] string status,
            [FromQuery] long oId)
        {
            var orderAmount = _orderApplication.GetAmountBy(oId);
            var verificationResponse = _zarinPalFactory.CreateVerificationRequest(authority, orderAmount.ToString(CultureInfo.InvariantCulture));
            var result = new PaymentResult();
            if (status == "OK" && verificationResponse.Status == 100)
            {
                var issueTrackingNo = _orderApplication.PaymentSucceeded(oId, verificationResponse.RefID);
                Response.Cookies.Delete(CookieName);
                result = result.Succeeded("پرداخت با موفقیت انجام شد.", issueTrackingNo);

                return RedirectToPage("/PaymentResult", result);

            }
            else
            {
                result = result.Failed("پرداخت با موفقیت انجام نشد. درصورت کسر وجه، تا 24 ساعت دیگر به حساب شما باز می گردد.");

                return RedirectToPage("/PaymentResult", result);
            }
        }
    }
}
