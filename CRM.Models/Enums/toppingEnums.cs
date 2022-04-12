using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace CRM.Models.Enums
{
    public enum toppingEnums
    {
        [Description("Onion")]
        Onion = 0,
        [Description("Grilled Mushrooms")]
        GrilledMushrooms = 1,
        [Description("Fresh Tomato")]
        FreshTomato = 2,

        [Description("Grilled Chicken Rasher")]
        GrilledChickenRasher = 3,
        [Description("Chicken Sausage")]
        ChickenSausage = 4,
        [Description("Chicken Tikka")]
        ChickenTikka = 5,
        [Description("Chilly Paneer")]
        ChillyPaneer = 6,
    }
}
