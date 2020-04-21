using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Hyungseok_Lee_Ex02
{
    public class Invoice
    {
        public int PartNumber { get; set; }
        public string PartDescription { get; set; }
        public int Quantity { get; set; }
        public decimal Price { get; set; }

        public override string ToString()
        {
            return $"\nPart number: {PartNumber}\n" +
                $"Part description: {PartDescription}\n" +
                $"Quantity: {Quantity}\n" +
                $"Price : {Price.ToString("c2")}\n";
        }
    }
}