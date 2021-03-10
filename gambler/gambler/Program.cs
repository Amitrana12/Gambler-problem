using System;

namespace gambler
{
    class Program
    {
        
        static void Main(string[] args)
        {
            int cost = 100;
            int betCost = 1;
            Random random = new Random();
            int Check = random.Next(0, 2);
            if (Check == 1)
            {
                Console.WriteLine("you win");
                cost++;
                Console.WriteLine("you left cost "+cost);
            }
            else {
                Console.WriteLine("you lose");
                cost--;
                Console.WriteLine("you left cost " + cost);
            }

        }
    }
}
