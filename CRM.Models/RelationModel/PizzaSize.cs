﻿using CRM.Framework.DataContext;
using CRM.Models.PizzaMenu;
using System;
using System.Collections.Generic;
using System.Text;

namespace CRM.Models.RelationModel
{
   public class PizzaSize: BaseEntity
    {
        public virtual PizzaMasterMenu PizzaMasterMenu { get; set; }

        public int PizzaId { get; set; }
        public int SizeType { get; set; }
    }
}
