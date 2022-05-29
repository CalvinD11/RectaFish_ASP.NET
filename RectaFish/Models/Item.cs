using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace RectaFish.Models
{
    public class Item
    {
        [Key]
        public int Id { get; set; }

        public string Name { get; set; }

        public string Description { get; set; }

        public int Stock { get; set; }

        public double Price { get; set; }

        //Relationship Table Between Item Tabel with Sale Tabel, using Item_Sale table
        public List<Item_Sale> Items_Sales { get; set; }
    }
}
