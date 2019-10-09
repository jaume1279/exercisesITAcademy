using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RepeatCharsPhase3
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

            foreach (char letra in lista)
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

            Dictionary<char, int> myDict = new Dictionary<char, int>();

            // upload to myDict the data contained in array Lista.
             
            for(int i=0; i<lista.Count; i++)
            {
                int repetition = 1;
                for(int i1=i+1;i1<(lista.Count); i1++)
                {
                    if (lista[i] == lista[i1]) repetition ++;
                }

                if(!myDict.ContainsKey(lista[i])) myDict.Add(lista[i], repetition);
            }

            Console.WriteLine("\nImprimo diccionario. Hay {0} registros.", myDict.Count);
            Console.WriteLine();


            foreach (var pair in myDict)
            {
                Console.WriteLine("La letra: {0} tiene: {1} repeticiones", pair.Key,pair.Value);
            }


            Console.WriteLine();
            Console.WriteLine("Pulsa Enter para salir");
            Console.ReadLine();

        }
    }
}
