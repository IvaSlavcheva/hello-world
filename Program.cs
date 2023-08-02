using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Dynamic;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;

namespace Project1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string brand = Console.ReadLine();
            double initialPrice = double.Parse(Console.ReadLine());
            double days = double.Parse(Console.ReadLine());

            double taxes = (20.0 / 100.0) * initialPrice;
            double priceAfterTaxes = initialPrice + taxes + 275;
            double resellValue = priceAfterTaxes +(days*20);
          
            double profit = (15.0 / 100.0) * resellValue;
            Console.WriteLine($"The {brand} with initial price of {initialPrice} BGN will sell for {resellValue} BGN ");
            Console.WriteLine($"Profit {profit} BGN");
        }
    }
}
