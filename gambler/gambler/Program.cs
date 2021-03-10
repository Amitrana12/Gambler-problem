using System;

namespace gambler
{
    class Program
    {
        
        static void Main(string[] args)
        {
            int totalCost = 100;
            int betCost = 1;
            Random random = new Random();
            int Check = random.Next(0, 2);
            if (Check == 1 && betCost==1)
            {
                Console.WriteLine("you win");
                totalCost++;
                Console.WriteLine("you left cost "+totalCost);
            }
            else {
                Console.WriteLine("you lose");
                totalCost--;
                Console.WriteLine("you left cost " + totalCost);
            }

        }
    }
}
