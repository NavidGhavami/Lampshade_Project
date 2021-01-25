using System.Collections.Generic;
using _0_Framework.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata.Internal;

namespace AccountManagement.Application.Contract.Role
{
    public class CreateRole
    {
        public string Name { get; set; }
        public List<int> Permissions { get; set; }
    }
}
