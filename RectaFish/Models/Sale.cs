using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace RectaFish.Models
{
    public class Sale
    {
        [Key]
        public int Id { get; set; }

        public string Quantity { get; set; }

        public double TotalCost { get; set; }

        //Relationship beetween Item_Sale and Sale table
        public List<Item_Sale> Items_Sales { get; set; }

        //Relationship between Sale with Buyer
        public Buyer Buyer { get; set; }
    }
}
