using System.Collections.Generic;
using _0_Framework;
using AccountManagement.Domain.AccountAgg;
using Microsoft.EntityFrameworkCore.Metadata.Internal;

namespace AccountManagement.Domain.Role
{
    public class Role : EntityBase
    {
        public string Name { get;private set; }
        public List<Account> Accounts { get;private set; }

        public Role(string name)
        {
            Name = name;
            Accounts = new List<Account>();
        }

        public void Edit(string name)
        {
            Name = name;
        }
    }
}
