using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RectaFish.Models
{
    public class Buyer
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime Date { get; set; }

        public Sale Sale { get; set; }
    }
}
