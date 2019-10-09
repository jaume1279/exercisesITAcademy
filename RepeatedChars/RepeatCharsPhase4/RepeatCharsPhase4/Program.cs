using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RepeatCharsPhase4
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Bienvenido al programa de procesamiento de caracteres !!");

            // Declaration and data entry of the two lists

            List<char> name = new List<char>();
            List<char> surname = new List<char>();

            wordEntry(name,"NOMBRE");
            wordEntry(surname,"APELLIDO");

            // Fusion both lists with one character (Space) between them = List "fullname"

            List<char> fullname = new List<char>();

            for(int i=0; i<name.Count(); i++)
            {
                fullname.Add(name[i]);
            }
            fullname.Add(' ');

            for (int i = 0; i < surname.Count(); i++)
            {
                fullname.Add(surname[i]);
            }

            // Print list "surname" to verify process

            Console.WriteLine();
            Console.WriteLine("Resultado del ejercicio:");
            Console.WriteLine();
            Console.Write("Fullname=[");
            for(int i=0; i<fullname.Count(); i++)
            {
                Console.Write("'"+fullname[i]);
                if (i < (fullname.Count()-1)) Console.Write("', ");
            }
            Console.Write("']");
            Console.ReadLine();

        }
        static List<char> wordEntry(List<char> llist, string palabra)
        {
            // Funtion to add values to a list of chars.

            Console.Write("\nIntroduce tu " + palabra + " letra a letra, para acabar entra * (asterisco): ");

           // List<char> name = new List<char>();
            ConsoleKeyInfo tecla;
            Boolean flag = true;

            do
            {
                Console.Write("\nIntroduce el caracter: ");
                tecla = Console.ReadKey();
                var pulsacion = tecla.KeyChar;
                if (char.IsLetter(pulsacion))
                    llist.Add(pulsacion);
                else if (pulsacion == '*')
                    flag = false;
                else
                    Console.WriteLine("\nLos nombres no tienen numeros !!");
            }
            while (flag);

            Console.WriteLine();

            return llist;

        }
    }
}
