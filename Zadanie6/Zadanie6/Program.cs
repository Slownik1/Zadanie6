using System;
using System.Windows;

namespace Zadanie6
{
    class Program
    {
        static void Main(string[] args)
        {
            

            Prizes[] tabOfPrizes = new Prizes[10];

            tabOfPrizes[0] = new Prizes('#', 3, 5);
            tabOfPrizes[1] = new Prizes('*', 3, 5);
            tabOfPrizes[2] = new Prizes('*', 7, 12);
            tabOfPrizes[3] = new Prizes('+', 15, 24);
            tabOfPrizes[4] = new Prizes('+', 19, 25);
            tabOfPrizes[5] = new Prizes('#', 12, 12);
            for (int i = 6; i < tabOfPrizes.Length; i++)
            {
                tabOfPrizes[i] = new Prizes();
            }

            for (int i = 1; i < tabOfPrizes.Length; i++)
            {
                Console.WriteLine(tabOfPrizes[i].Print(tabOfPrizes, i));
            }

            String title = $"{Prizes.Sum(tabOfPrizes)} ZNAKI W KONSOLI";
            Console.Title = title;

            Console.ReadKey(false);

        }
    }
}
