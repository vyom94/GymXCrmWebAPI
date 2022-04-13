using System;
using System.Collections.Generic;
using System.Text;

namespace CRM.Models.Dto
{
    public class PizzaDto
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string ImageUrl { get; set; }

        public int Price { get; set; }
    }
}
