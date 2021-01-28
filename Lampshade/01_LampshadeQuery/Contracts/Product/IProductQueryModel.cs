using System.Collections.Generic;
using ShopManagement.Application.Contract.Order;

namespace _01_LampshadeQuery.Contracts.Product
{
    public interface IProductQueryModel
    {
        List<ProductQueryModel> GetLatestProducts();
        List<ProductQueryModel> Search(string value);
        ProductQueryModel GetProductDetails(string slug);
        List<CartItem> CheckInventoryStatus(List<CartItem> cartItems);
    }
}
