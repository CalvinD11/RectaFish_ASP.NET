using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RectaFish.Models
{
    public class Item_Sale
    {
        public int ItemId { get; set; }

        public Item Item { get; set; }

        public int SaleId { get; set; }

        public Sale Sale { get; set; }
    }
}
