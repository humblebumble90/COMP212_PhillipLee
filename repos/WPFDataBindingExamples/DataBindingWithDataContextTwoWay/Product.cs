using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataBindingWithDataContextTwoWay
{
 

  public  class Product
    {
        public string Name { get; set; }

        private double price;
        public double Price
        {
            get
            {
                return price;
            }
            set
            {
                if (value != price)
                {
                    price = value;
                }
            }
        }
    } // end class
} // end namespace
