using CRM.Framework.DataContext;
using System;
using System.Collections.Generic;
using System.Text;

namespace CRM.Models.User
{
    public class User : BaseEntity
    {
        public string UserName { get; set; }
        public  string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
    }
}
