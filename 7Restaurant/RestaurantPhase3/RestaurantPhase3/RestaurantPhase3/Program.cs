using System;
using System.Collections.Generic;

namespace RestaurantPhase3
{
    class Program
    {
        static void Main(string[] args)
        {
            int pm1 = 1;
            int pm2 = 2;
            int pm5 = 5;
            int pm10 = 10;
            int pm20 = 20;
            int pm50 = 50;
            int pm100 = 100;
            int pm200 = 200;
            int pm500 = 500;

            int mealPrice = 0;

            const int NrRecipes = 5;

            string[] menu = new string[NrRecipes];
            int[] priceDish = new int[NrRecipes];

            #region Enter menu

            Console.WriteLine("Vamos a introducir el nombre y el precio de los platos: ");
            for (int i = 0; i < NrRecipes; i++)
            {
                Console.Write($"Nombre del plato {(i + 1)}: ");
                menu[i] = Console.ReadLine();
                do
                {
                    Console.Write($"Precio del plato {(i + 1)}: ");
                }
                while (!(int.TryParse(Console.ReadLine().Replace(".", ","), out priceDish[i])));
                Console.WriteLine();
            }

            #endregion

            #region Read Dishes

            Console.WriteLine("Los platos a escoger son:");
            Console.WriteLine("Precio      #  Plato");
            Console.WriteLine("------------#----------------------------");
            for (int i = 0; i < NrRecipes; i++)
            {
                Console.Write(priceDish[i]);
                int counter = priceDish[i].ToString().Length;
                do
                {
                    Console.Write(".");
                    counter++;
                }
                while (counter < 12);

                Console.WriteLine($"#  {menu[i]}");
            }

            #endregion

            #region Read Choosen Dishes

            Console.WriteLine();
            Console.WriteLine("Entra los platos que deseas para comer: ");

            List<string> choosenDishes = new List<string>();
            int j = 0;
            int option;
            bool menuAdd;

            do
            {
                Console.WriteLine($"Plato num: {(j + 1)}");
                choosenDishes.Add(Console.ReadLine());
                j++;

                do
                {
                    Console.WriteLine("Mas platos? Pulsa 1 para introducir mas platos, 2 para salir ");
                    menuAdd = (int.TryParse(Console.ReadLine(), out option));
                }
                while (!menuAdd || (option > 2));
            }
            while (option == 1);

            Console.WriteLine();

            #endregion

            #region Check menu with choosen dishes, total amount

            bool exit = false;

            Console.WriteLine();
            Console.WriteLine($"Han escogido {choosenDishes.Count} platos y son:");
            Console.WriteLine();

            foreach (string item in choosenDishes)
            {
                exit = false;
                int index = 0;
                do
                {
                    if (item.ToUpper() == menu[index].ToUpper())
                    {
                        mealPrice += priceDish[index];
                        exit = true;
                    }
                    index++;
                }
                while (!(exit) && (index != NrRecipes));

                if (!exit)
                {
                    Console.WriteLine($"El plato: {item}, no está en la carta de este restaurante.");
                }
                else
                {
                    Console.WriteLine($"Has pedido el plato: {item} y la comida de momento cuesta: {mealPrice}");
                }
            }



            Console.WriteLine();
            Console.WriteLine($"El coste total de la comida es: {mealPrice}");

            #endregion

            #region bills for paying mealPrice

            int rest = mealPrice;

            Console.WriteLine();
            Console.WriteLine("Puedes pagar con tarjeta de crédito o con cash. Si pagas en cash el desglose es:");
            Console.WriteLine();

            var restp500 = checkBill(rest, pm500);
            var restp200 = checkBill(restp500, pm200);
            var restp100 = checkBill(restp200, pm100);
            var restp50 = checkBill(restp100, pm50);
            var restp20 = checkBill(restp50, pm20);
            var restp10 = checkBill(restp20, pm10);
            var restp5 = checkBill(restp10, pm5);
            var restp2 = checkBill(restp5, pm2);
            var restp1 = checkBill(restp2, pm1);


            if (restp5 == 0)
            {
                Console.WriteLine();
                Console.WriteLine("Deseamos haya tenido una buena comida, hasta la próxima !!!");
                Console.ReadLine();
            }


            #endregion

            Console.ReadLine();

        }


        static int checkBill(int amount, int bill)
        {
            if ((Math.Truncate((double)(amount / bill))) > 0)
            {
                Console.WriteLine($"{Math.Truncate((decimal)(amount / bill))} billetes de {bill}");
                amount -= (int)((Math.Truncate((decimal)((amount / bill)) * bill)));
            }

            return amount;
        }
    }
}
