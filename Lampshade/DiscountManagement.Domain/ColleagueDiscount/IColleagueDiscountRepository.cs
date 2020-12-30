﻿using System.Collections.Generic;
using _0_Framework.Domain;
using DiscountManagement.Application.Contract.ColleagueDiscount;

namespace DiscountManagement.Domain.ColleagueDiscount
{
    public interface IColleagueDiscountRepository : IRepository<long, ColleagueDiscount>
    {
        EditColleagueDiscount GetDetails(long id);
        List<ColleagueDiscountViewModel> Search(ColleagueDiscountSearchModel searchModel);
    }
}
