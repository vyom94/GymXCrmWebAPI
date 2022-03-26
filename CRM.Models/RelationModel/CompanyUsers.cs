using CRM.Framework.DataContext;
using CRM.Models.SysConfig;
using CRM.Models.User;
using System;
using System.Collections.Generic;
using System.Text;

namespace CRM.Models.RelationModel
{
    public class CompanyUsers:BaseMasterEntity
    {
        public virtual Users Users { get; set; }
        public virtual Company Company { get; set; }
        public int CompanyID { get; set; }
        public int UserID { get; set; }
    }
}
