using System.Collections.Generic;
using _01_LampshadeQuery.Contracts.Product;

namespace _01_LampshadeQuery.Contracts.ProductCategory
{
    public interface IProductCategoryQuery
    {
        List<ProductCategoryQueryModel> GetProductCategory();
        List<ProductCategoryQueryModel> GetProductCategoriesWithProducts();
    }
}