using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantPhase2
{
    class Program
    {
        static void Main(string[] args)
        {
            int pm5 = 5;
            int pm10 = 10;
            int pm20 = 20;
            int pm50 = 50;
            int pm100 = 100;
            int pm200 = 200;
            int pm500 = 500;

            const int NrRecipes= 5;

            string[] menu = new string[NrRecipes];
            double[] priceDish = new double[NrRecipes];

            Console.WriteLine("Vamos a introducir el nombre y el precio de los platos: ");
            for (int i = 0; i < NrRecipes; i++)
            {
                Console.Write("Nombre del plato " + (i+1) + ": ");
                menu[i] = Console.ReadLine();
                do
                {
                    Console.Write("Precio del plato " + (i + 1) + ": ");
                }
                while (!(double.TryParse(Console.ReadLine().Replace(".", ","), out priceDish[i])));
                Console.WriteLine();
            }


            Console.WriteLine("Los platos a escoger son:");
            Console.WriteLine("Precio      #  Plato");
            Console.WriteLine("------------#----------------------------");
            for(int i=0; i< NrRecipes; i++)
            {
                Console.Write(priceDish[i]);
                int cont = priceDish[i].ToString().Length;
                do
                {
                    Console.Write(".");
                    cont++;
                }
                while (cont < 12);

                Console.WriteLine("#  " + menu[i]);
            }

            Console.WriteLine();
            Console.WriteLine("Entra los platos que deseas para comer, (*) para finalizar: ");

            List<string> choosenDishes = new List<string>();
            int j = 0;

            do
            {
                Console.WriteLine("Plato num: " + (j+1));
                choosenDishes.Add(Console.ReadLine());
                j++;
                Console.WriteLine("Mas platos? Pulsa 1 para finalizar, otra tecla para seguir ");
            }
            while ((Console.ReadKey().KeyChar) != '*') ;

            Console.WriteLine();

            Console.WriteLine("Han escogido " + choosenDishes.Count + " platos y son:");
            for(int i=0; i<choosenDishes.Count; i++)
            {
                Console.WriteLine((i+1) + " : " + choosenDishes[i]);
            }






            Console.ReadLine();

        }
    }
}
