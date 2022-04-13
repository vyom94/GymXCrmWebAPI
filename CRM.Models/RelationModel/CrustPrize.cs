using CRM.Framework.DataContext;
using System;
using System.Collections.Generic;
using System.Text;

namespace CRM.Models.RelationModel
{
    public class CrustPrice:BaseEntity
    {
        public int CrustType { get; set; }
        public int Price { get; set; }
        public virtual PizzaCrust PizzaCrust { get; set; }
    }
}
