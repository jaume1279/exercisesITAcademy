using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exVariablesPhase1
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

            Console.WriteLine("Los string son: " + cognom1 + " " + cognom2 + ", " + nom);

            Console.WriteLine("Los int son: " + dia + "/" + mes + "/" + any);

            Console.ReadLine();

        }
    }
}
