using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RepeatCharsPhase1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Bienvenido al programa de procesamiento de caracteres !!");
            Console.Write("\nDime cuantas letras tiene la palabra que vas a introducir: ");

            int numChar = int.Parse(Console.ReadLine());
            char[] name=new char[numChar];
            ConsoleKeyInfo tecla;
            

            for (int i=0; i < numChar; i++)
            {
                Console.Write("\nIntroduce el caracter {0}: " , (i+1));
                tecla = Console.ReadKey();
                if (!(char.IsDigit(tecla.KeyChar)))
                    name[i] = tecla.KeyChar;
                else
                {
                    Console.WriteLine("\nLos nombres solo tienen letras!!!! Vuelve a introducir:");
                    i--;
                }
                    
            }

            Console.WriteLine();
            Console.WriteLine("\n La palabra introducida es:");
            Console.WriteLine();
            foreach(char letra in name)
            {
                Console.Write(letra);
            }

            Console.WriteLine();
            Console.WriteLine("Pulsa Enter para salir");
            Console.ReadLine();
        }
    }
}
