using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exerciciVariablesPhase2
{
    class Program
    {
        static void Main(string[] args)
        {
            string nom       = "Jaume";
            string cognom1   = "Sabate";
            string cognom2   = "Fabregat";

            int dia = 18;
            int mes = 10;
            int any = 1970;

            const int anyInici = 1948;
            const int cadencia = 4;
            int nrLeap = 0;

            for(int i=anyInici; i<=any; i = i + 4)
                {
                    nrLeap += 1;
                }

            Console.WriteLine("Numero de bisiestos entre " + anyInici + " i " + any + " son: " + nrLeap);

            Console.ReadLine();

        }
    }
}
