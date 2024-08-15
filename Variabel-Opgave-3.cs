using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Security;
using System.Text;
using System.Threading.Tasks;

namespace Opgave1
{
    class Program
    {
        static void Main(string[] args)
        {
            string Navn = "Søren";
            int Alder = 16;
            double Penge = 1234.34;

            Console.WriteLine($"Jeg hedder {Navn}, er {Alder} år gammel og har tjent {Penge} kr. på at lappe cykler.");
            Console.ReadKey();
        }
    }
}
