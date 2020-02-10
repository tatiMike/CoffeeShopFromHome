using System;
using System.Collections.Generic;

namespace RoastsCoffeeShopApp.Models
{
    public partial class ItemsCoffee
    {
        public int ItemId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public int Quantity { get; set; }
        public decimal Price { get; set; }
    }
}
