using System.Collections.Generic;
using AccountManagement.Application.Contract.Account;
using AccountManagement.Application.Contract.Role;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace ServiceHost.Areas.Adminstration.Pages.Accounts.Roles
{
    public class IndexModel : PageModel
    {
        [TempData] public string Message { get; set; }

        public List<RoleViewModel> Role;
        private readonly IRoleApplication _roleApplication;


        public IndexModel(IRoleApplication roleApplication)
        {
            _roleApplication = roleApplication;
        }


        public void OnGet(AccountSearchModel searchModel)
        {
            Role = _roleApplication.List();
        }

    }
}
