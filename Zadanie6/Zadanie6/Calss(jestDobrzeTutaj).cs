using System;
using System.Collections.Generic;
using System.Text;


namespace Zadanie6
{
    class Prizes
    {
        public char prize;
        public int height;
        public int width;
        public char[] prizeSymbols = { '*', '+', '#' };
        int sum;

        public Prizes(){

            Random los = new Random();
            this.prize = prizeSymbols[los.Next(3)];
            this.height = los.Next(Console.WindowHeight);
            this.width = los.Next(Console.WindowWidth);

        }

        public Prizes(char prize, int height, int width)
        {

            this.prize = prize;
            this.height = height;
            this.width = width;

        }

        public char Print(Prizes[] prize, int i)
        {
            for (int j = 0; j < prize.Length; j++)
            {
                Console.SetCursorPosition(width, height);

                if ((prize[i - 1].width == prize[i].width) && (prize[i - 1].height == prize[i].height))
                    return 'X';
                else
                    return prize[i].prize;
            }
            return '@';

        }

        static public int Sum(Prizes[] prize) {

        int sum=0;


        for (int i = 0; i < prize.Length; i++)
            {
                if (prize[i].prize == '*')
                    sum += 10;
                if (prize[i].prize == '+')
                    sum += 5;
                if (prize[i].prize == '#')
                    sum += 2;
             }

            return sum;

        }

    }
}
