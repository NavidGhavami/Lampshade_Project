using System.Collections.Generic;
using _0_Framework.Domain;
using DiscountManagement.Application.Contract.CustomerDiscount;

namespace DiscountManagement.Domain
{
    public interface ICustomerDiscountRepository : IRepository<long,CustomerDiscount.CustomerDiscount>
    {
        EditCustomerDiscount GetDetails(long id);
        List<CustomerDiscountViewModel> Search(CustomerDiscountSearchModel searchModel);
    }
}
