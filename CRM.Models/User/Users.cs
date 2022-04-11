using CRM.Framework.DataContext;
using CRM.Models.RelationModel;
using System;
using System.Collections.Generic;
using System.Text;

namespace CRM.Models.User
{
    public class Users: BaseEntity
    {
        public string UserName { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }

        public ICollection<CompanyUsers> CompanyUsers { get; set; }
    }
}
