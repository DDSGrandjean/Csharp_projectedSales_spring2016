//DYLAN GRANDJEAN
//February 10th, 2016
//Program to forsee increased projected sales for two regions

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectedSales
{
    class Main
    {
        static void Main(string[] args)
        {
            //Instantiate variables
            double reg1Sales,
                   reg2Sales,
                   reg1PerIncrease,
                   reg2PerIncrease;

            //Heading
            Console.WriteLine("****PROJECTED SALES INCREASE****\n");

            //Get user inputs
            Console.Write("What is the sale for Region 1?: ");
            reg1Sales = Convert.ToDouble(Console.ReadLine());

            Console.Write("What is the percentage increase decimal for Region 1?: ");
            reg1PerIncrease = (Convert.ToDouble(Console.ReadLine())/100);

            Console.Write("What is the sale for Region 2?: ");
            reg2Sales = Convert.ToDouble(Console.ReadLine());

            Console.Write("What is the percentage increase decimal for Region 2?: ");
            reg2PerIncrease = (Convert.ToDouble(Console.ReadLine())/100);

            double reg1Increase = reg1Sales * reg1PerIncrease,
                   reg2Increase = reg2Sales * reg2PerIncrease,

                   reg1ProjSales = reg1Sales + reg1Increase,
                   reg2ProjSales = reg2Sales + reg2Increase;

            Console.WriteLine("\nThe projected sale for Region 1 is: {0:c}", reg1ProjSales);
            Console.WriteLine("The projected sale for Region 2 is: {0:c}", reg2ProjSales);
            Console.Read();
        }
    }
}
