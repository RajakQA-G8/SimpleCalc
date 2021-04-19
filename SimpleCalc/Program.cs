using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleCalc
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Jednostavni kalkulator");

            double a, b, rezultat = 0;

            Console.Write("Unesite zeljenu operaciju (+, -, *, /) > ");
            string operacija = Console.ReadLine();

            Console.Write("Unesite prvi operand (a) > ");
            a = Convert.ToDouble(Console.ReadLine());
            Console.Write("Unesite drugi operand (b) > ");
            b = Convert.ToDouble(Console.ReadLine());

            switch (operacija)
            {
                case "+":
                    rezultat = a + b;
                    break;
                case "-":
                    rezultat = a - b;
                    break;
                case "*":
                    rezultat = a * b;
                    break;
                case "/":
                    rezultat = a / b;
                    break;
                default:
                    Console.WriteLine("Nepoznata operacija");
                    Environment.Exit(1);
                    break;
            }

            //                                              0  1     2          3
            Console.WriteLine("Rezultat {0} {3} {1} = {2}", a, b, rezultat, operacija);


            Console.ReadKey();
        }
    }
}
