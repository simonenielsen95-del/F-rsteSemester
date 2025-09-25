using Pro_05Ny;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculatorApp
{


    internal class Program
    {

        static void Main(string[] args)
        {

            Calculator calc = new Calculator();
           



            int t = calc.Add(5, 3);

            double g = calc.Divide(10, 3);

            //decimal g = Math.Round(calc2.Divide(5, 2), 2);

            Console.WriteLine("Calculator says:" + g);
            
        }
    }

}
