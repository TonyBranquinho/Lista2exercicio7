using System;
using System.Globalization;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program {
        static void Main(string[] args) {

            CultureInfo CI = CultureInfo.InvariantCulture;

            Console.WriteLine("Escreva 2 valores com uma casa decimal");
            string[] vet = Console.ReadLine().Split(' ');
            double x = double.Parse(vet[0], CI);
            double y = double.Parse(vet[1], CI);

            if (x > 0 && y > 0) {
                Console.WriteLine("Q1");
            }
            else if (x < 0 && y < 0) {
                Console.WriteLine("Q3");
            }
            else if (x < 0 && y > 0) {
                Console.WriteLine("Q2");
            }
            else if (x > 0 && y < 0) {
                Console.WriteLine("Q4");
            }

            else if ( x == 0 && y == 0) {
                Console.WriteLine("Origem");
            }
            else if (x == 0) {
                Console.WriteLine("Eixo Y");
            }
            else if (y == 0) {
                Console.WriteLine("Eixo X");
            }

         }
    }
}