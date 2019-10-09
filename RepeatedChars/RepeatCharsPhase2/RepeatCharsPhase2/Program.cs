using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RepeatCharsPhase2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Bienvenido al programa de procesamiento de caracteres !!");
            Console.Write("\nIntroduce tu nombre letra a letra, para acabar entra * (asterisco): ");

            List<char> lista = new List<char>();
            ConsoleKeyInfo tecla;
            Boolean flag = true;
            int num;

            do
            {
                Console.Write("\nIntroduce el caracter: ");
                tecla = Console.ReadKey();
                var pulsacion = tecla.KeyChar;
                if (char.IsLetter(pulsacion))
                    lista.Add(pulsacion);
                else if (pulsacion == '*')
                    flag = false;
                    else
                        Console.WriteLine("\nLos nombres no tienen numeros !!");
            }
            while (flag);

            Console.WriteLine();

            foreach(char letra in lista)
            {
                var letraCap = char.ToUpper(letra);
                string s;

                if ((letraCap.ToString() == "A")
                    || (letraCap.ToString() == "E")
                    || (letraCap.ToString() == "I")
                    || (letraCap.ToString() == "O")
                    || (letraCap.ToString() == "U"))
                    s = "Vocal";
                else
                    s = "Consonante";
                Console.WriteLine();
                Console.WriteLine(letraCap + " " + s);
            }
          
            Console.WriteLine();
            Console.WriteLine("Pulsa Enter para salir");
            Console.ReadLine();
        }
    }
}
