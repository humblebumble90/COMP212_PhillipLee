using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hyungseok_Lee_Ex02
{
    class Program
    {
        private static Invoice[] invoiceArr = new Invoice[7];
        private static Invoice electricSander;
        private static Invoice powerSaw;
        private static Invoice sledgeHammer;
        private static Invoice hammer;
        private static Invoice lawnMower;
        private static Invoice screwDriver;
        private static Invoice jigSaw;
        static void Main(string[] args)
        {
            generateInvoices();
            setInvoiceArray(invoiceArr);
            displayInvoiceArray();
            displayInvoiceTotal();
            displayHighestQuantity();
            displayAvgPrice();
        }

        private static void displayInvoiceTotal()
        {
            Console.WriteLine("Excercise02_a) InvoiceTotal");
            var invoiceTotal =
                from item in invoiceArr
                let value = item.Price * item.Quantity
                orderby value ascending
                select value;

            foreach (var item in invoiceTotal)
            {
                Console.WriteLine(item.ToString("c2"));
            }
        }

        private static void displayHighestQuantity()
        {
            Console.WriteLine("\nExercise02_b) Highest quantity");
            var highestQuantity = invoiceArr.Select(x => x.Quantity).Max();
            Console.WriteLine(highestQuantity);
        }

        private static void displayAvgPrice()
        {
            Console.WriteLine("\nExcercise02_c) Average price of the parts");
            var avgPrice = invoiceArr.Select(x => x.Price).Average();
            Console.WriteLine(avgPrice.ToString("C2"));
        }

        private static void displayInvoiceArray()
        {
            foreach (var item in invoiceArr)
            {
                Console.WriteLine(item);
            }
        }
        private static void generateInvoices()
        {
            electricSander = new Invoice()
            {
                PartNumber = 87,
                PartDescription = "Electric Sander",
                Quantity = 7,
                Price = 57.98m
            };
            powerSaw = new Invoice()
            {
                PartNumber = 24,
                PartDescription = "Power Saw",
                Quantity = 18,
                Price = 99.99m
            };
            sledgeHammer = new Invoice()
            {
                PartNumber = 7,
                PartDescription = "Sledge Hammer",
                Quantity = 11,
                Price = 21.50m
            };
            hammer = new Invoice()
            {
                PartNumber = 77,
                PartDescription = "Hammer",
                Quantity = 76,
                Price = 11.99m
            };
            lawnMower = new Invoice()
            {
                PartNumber = 39,
                PartDescription = "Lawn Mower",
                Quantity = 3,
                Price = 79.50m
            };
            screwDriver = new Invoice()
            {
                PartNumber = 68,
                PartDescription = "Screw Driver",
                Quantity = 106,
                Price = 6.99m
            };
            jigSaw = new Invoice()
            {
                PartNumber = 56,
                PartDescription = "Jig Saw",
                Quantity = 21,
                Price = 11.00m
            };
        }
        private static void setInvoiceArray(Invoice[] invoiceArr)
        {
            invoiceArr[0] = electricSander;
            invoiceArr[1] = powerSaw;
            invoiceArr[2] = sledgeHammer;
            invoiceArr[3] = hammer;
            invoiceArr[4] = lawnMower;
            invoiceArr[5] = screwDriver;
            invoiceArr[6] = jigSaw;
        }

        
    }
}
