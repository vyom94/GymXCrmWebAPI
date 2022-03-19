using CRM.Framework.DataContext;
using System;
using System.Collections.Generic;
using System.Text;

namespace CRM.Models.SysConfig
{
    public class Company: BaseEntity
    {
        public string CompanyName { get; set; }
        public string Email { get; set; }
        public string Contact { get; set; }
        public string Address { get; set; }
        public string CompanyLogo { get; set; }
    }
}
