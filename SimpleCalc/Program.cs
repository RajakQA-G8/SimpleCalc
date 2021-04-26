using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleCalc
{
    class Program
    {

        public static double KorisnickiUnosOperanda()
        {
            Console.Write("Unesite operand > ");

            return Convert.ToDouble(Console.ReadLine());
        }

        public static string KorisnickiUnos(string poruka)
        {
            Console.Write("{0} > ", poruka);

            return Console.ReadLine();
        }

        public static void Izracunaj(string operacija, double operand1, double operand2, out double rezultat)
        {
            rezultat = 0;

            switch (operacija)
            {
                case "+":
                    rezultat = operand1 + operand2;
                    break;
                case "-":
                    rezultat = operand1 - operand2;
                    break;
                case "*":
                    rezultat = operand1 * operand2;
                    break;
                case "/":
                    rezultat = operand1 / operand2;
                    break;
                case "~":
                    Swap(ref operand1, ref operand2);
                    Console.WriteLine("Nakon zamene pozicija: {0} {1}", operand1, operand2);
                    break;
                case "P":
                    double p = 0;
                    Console.WriteLine("Vrednost pi pre poziva = {0}", p);
                    Pi(out p);
                    Console.WriteLine("Vrednost pi nakon poziva = {0}", p);
                    break;
                default:
                    Console.WriteLine("Nepoznata operacija");
                    break;
            }
        }

        public static void Swap(ref double a, ref double b)
        {
            double temp;

            temp = a;
            a = b;
            b = temp;
        }

        public static void Pi(out double pi)
        {
            pi = 3.14159;
        }

        static void Main(string[] args)
        {
            
            Console.WriteLine("Jednostavni kalkulator");

            const string POTVRDA = "y";

            double a, b, rezultat = 0;
            string odgovor = POTVRDA;

            while (odgovor == POTVRDA) {

                string operacija = KorisnickiUnos("Unesite zeljenu operaciju (+, -, *, /, ~, P)");


                a = KorisnickiUnosOperanda();
                b = KorisnickiUnosOperanda();

                Izracunaj(operacija, a, b, out rezultat);

                //                                              0  1     2          3
                Console.WriteLine("Rezultat {0} {3} {1} = {2}", a, b, rezultat, operacija);

                odgovor = KorisnickiUnos("Upisite " + POTVRDA + " da nastavite, bilo sta drugo prekida rad").ToLower();
            }


            int i = 10, j = 10;
            
            while (i < 20)
            {
                j = 0;
                while (j < 20) {
                    Console.WriteLine("[while] Vrednost je {0}", i);
                    j++;
                }
                i++;
            }

            do
            {
                Console.WriteLine("[do..while] Vrednost je {0}", i);
                i++;
            } while (i < 20);

            for (int brojac = 0; brojac < 10; brojac++)
            {
                Console.WriteLine("[for] Vrednost je {0}", brojac);
            }

            Console.ReadKey();
        }
    }
}
