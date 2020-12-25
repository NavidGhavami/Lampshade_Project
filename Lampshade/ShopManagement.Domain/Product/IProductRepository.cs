using System;
using System.Collections.Generic;
using System.Text;
using _0_Framework.Domain;
using ShopManagement.Application.Contract.Product;

namespace ShopManagement.Domain.Product
{
    public interface IProductRepository : IRepository<long, Product>
    {
        List<ProductViewModel> Search(ProductSearchModel searchModel);
        EditProduct GetDetails(long id);
        List<ProductViewModel> GetProducts();

    }
}
