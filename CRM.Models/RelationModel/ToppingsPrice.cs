using CRM.Framework.DataContext;
using System;
using System.Collections.Generic;
using System.Text;

namespace CRM.Models.RelationModel
{
    public class ToppingsPrice:BaseEntity
    {
        public int ToppingType { get; set; }
        public int Price { get; set; }
       
    }
}
