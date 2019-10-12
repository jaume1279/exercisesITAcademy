using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CiutatsPhase1
{
    class Program
    {
        static void Main(string[] args)
        {
            string city1, city2, city3, city4, city5, city6;

            Console.WriteLine("Entra el nombre de la ciudad 1: ");
            city1 = Console.ReadLine();

            Console.WriteLine("Entra el nombre de la ciudad 2: ");
            city2 = Console.ReadLine();

            Console.WriteLine("Entra el nombre de la ciudad 3: ");
            city3 = Console.ReadLine();

            Console.WriteLine("Entra el nombre de la ciudad 4: ");
            city4 = Console.ReadLine();

            Console.WriteLine("Entra el nombre de la ciudad 5: ");
            city5 = Console.ReadLine();

            Console.WriteLine("Entra el nombre de la ciudad 6: ");
            city6 = Console.ReadLine();


            Console.WriteLine("Els noms de les ciutats son: " + city1 + " # " +
                                                                city2 + " # " +
                                                                city3 + " # " +
                                                                city4 + " # " +
                                                                city5 + " # " +
                                                                city6);
            Console.ReadLine();
        }
    }
}
