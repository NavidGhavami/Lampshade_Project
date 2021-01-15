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

        public IActionResult OnGetCreate()
        {
            var command = new CreateRole();
            return Partial("./Create", command);
        }

        public JsonResult OnPostCreate(CreateRole command)
        {
            var result = _roleApplication.CreateRole(command);

            return new JsonResult(result);
        }

        public IActionResult OnGetEdit(long id)
        {
            var role = _roleApplication.GetDetails(id);
            return Partial("Edit", role);
        }

        public JsonResult OnPostEdit(EditRole command)
        {
            var result = _roleApplication.EditRole(command);
            return new JsonResult(result);
        }
    }
}
