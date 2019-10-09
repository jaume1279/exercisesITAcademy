using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exerciciVariablesPhase3
{
    class Program
    {
        static void Main(string[] args)
        {
            string nom = "Jaume";
            string cognom1 = "Sabate";
            string cognom2 = "Fabregat";

            int dia = 18;
            int mes = 10;
            int any = 1970;

            const int anyInici = 1948;
            const int cadencia = 4;
            int nrLeap = 0;
            Boolean isLeap=false;
            

            for (int i = anyInici; i <= any; i = i + 1)
            {
                if((i%4) == 0)
                {
                    nrLeap += 1;
                    isLeap = true;
                   // Console.WriteLine("Año bisiesto: " + i);
                }
                else
                {
                    isLeap = false;
                }

                string message;

                if (isLeap)
                {
                    message = "El año " + i + " SI es bisiesto.";
                }
                else
                {
                    message = "El año " + i + " NO es bisiesto.";
                }

                Console.WriteLine(message);
            }

            Console.WriteLine("Numero de bisiestos entre " + anyInici + " i " + any + " son: " + nrLeap);
            Console.WriteLine();



            Console.ReadLine();
        }
    }
}
