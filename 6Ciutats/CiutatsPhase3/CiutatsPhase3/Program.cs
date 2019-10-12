using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CiutatsPhase3
{
    class Program
    {
        static void Main(string[] args)
        {


            #region PHASE1

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


            #endregion
            #region PHASE2



            string[] arrayCiutats = new string[6] { city1, city2, city3, city4, city5, city6 };

            Console.WriteLine("Phase2: ciutats ordenades per ordre alfabetic:");
            Array.Sort(arrayCiutats);
            foreach (string city in arrayCiutats)
                Console.Write(city + " # ");

            #endregion

            Console.ReadLine();

            #region PHASE3

            string[] arrayCiutatsModificades = new string[6];

            for(int index=0; index<arrayCiutats.Length; index ++)
            {
                arrayCiutatsModificades[index]=arrayCiutats[index].Replace("a", "4");
            }
            Console.WriteLine();
            Console.WriteLine("Phase3: ciutats modificades ordenades per ordre alfabetic:");
            Array.Sort(arrayCiutatsModificades);
            foreach (string city in arrayCiutatsModificades)
                Console.Write(city + " # ");

            #endregion

            Console.ReadLine();



        }
    }
}
