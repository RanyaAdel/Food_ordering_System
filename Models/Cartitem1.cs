using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Food_ordering_System.Models
{
    public class Cartitem1
    {
        public int ShoppingCartItemId { get; set; }
        public FoodItem FoodItem { get; set; }
        public int Amount { get; set; }
        

    }
}