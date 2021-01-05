using System.Collections.Generic;

namespace _01_LampshadeQuery.Contracts.Product
{
    public interface IProductQueryModel
    {
        List<ProductQueryModel> GetLatestProducts();
    }
}
