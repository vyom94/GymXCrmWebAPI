using CRM.Framework.DataContext;
using CRM.Models.RelationModel;
using System;
using System.Collections.Generic;
using System.Text;

namespace CRM.Models.PizzaMenu
{
    public class PizzaMasterMenu:BaseEntity
    {
        public string Name { get; set; }
        public ICollection<PizzaCrust> PizzaCrust { get; set; }
        public ICollection<PizzaSize> PizzaSize { get; set; }
        public ICollection<PizzaToppings> PizzaToppings { get; set; }
    }
}
