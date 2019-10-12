using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CiutatsPhase4
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

            for (int index = 0; index < arrayCiutats.Length; index++)
            {
                arrayCiutatsModificades[index] = arrayCiutats[index].Replace("a", "4");
            }
            Console.WriteLine();
            Console.WriteLine("Phase3: ciutats modificades ordenades per ordre alfabetic:");
            Array.Sort(arrayCiutatsModificades);
            foreach (string city in arrayCiutatsModificades)
                Console.Write(city + " # ");

            #endregion

            Console.ReadLine();


            #region PHASE4

            char[] arrayCity1 = new char[arrayCiutats[0].Length];
            char[] arrayCity2 = new char[arrayCiutats[1].Length];
            char[] arrayCity3 = new char[arrayCiutats[2].Length];
            char[] arrayCity4 = new char[arrayCiutats[3].Length];
            char[] arrayCity5 = new char[arrayCiutats[4].Length];
            char[] arrayCity6 = new char[arrayCiutats[5].Length];

            arrayCity1 = arrayCiutats[0].ToCharArray(0, arrayCiutats[0].Length);
            arrayCity2 = arrayCiutats[1].ToCharArray(0, arrayCiutats[1].Length);
            arrayCity3 = arrayCiutats[2].ToCharArray(0, arrayCiutats[2].Length);
            arrayCity4 = arrayCiutats[3].ToCharArray(0, arrayCiutats[3].Length);
            arrayCity5 = arrayCiutats[4].ToCharArray(0, arrayCiutats[4].Length);
            arrayCity6 = arrayCiutats[5].ToCharArray(0, arrayCiutats[5].Length);

            Console.WriteLine();
            Console.WriteLine("Phase4: ciutats amb els noms invertits:");
            Array.Reverse(arrayCity1);
            Array.Reverse(arrayCity2);
            Array.Reverse(arrayCity3);
            Array.Reverse(arrayCity4);
            Array.Reverse(arrayCity5);
            Array.Reverse(arrayCity6);

            foreach (char letter in arrayCity1)
                Console.Write(letter);

            Console.WriteLine();

            foreach(char letter in arrayCity2)
                Console.Write(letter);

            Console.WriteLine();

            foreach(char letter in arrayCity3)
                Console.Write(letter);

            Console.WriteLine();

            foreach(char letter in arrayCity4)
                Console.Write(letter);

            Console.WriteLine();

            foreach(char letter in arrayCity5)
                Console.Write(letter);

            Console.WriteLine();

            foreach(char letter in arrayCity6)
                Console.Write(letter);


            #endregion

            Console.ReadLine();
        }
    }
}
