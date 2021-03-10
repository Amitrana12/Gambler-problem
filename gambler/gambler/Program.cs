using System;

namespace gambler
{
    class Program
    {
        public static int totalCost = 100;
       public static  int betCost = 1;
      

        static void Main(string[] args)
        {
            
            
            winOrLose();


        }
        public static void winOrLose()
        {
           
            while (totalCost != 150 && totalCost != 50)
            {
                Random random = new Random();
                int Check = random.Next(0, 2);
                if (Check == 1 && betCost == 1 )
                {
                    Console.WriteLine("you win");
                    totalCost++;
                    Console.WriteLine("you left cost " + totalCost);
                }
                else
                {
                    Console.WriteLine("you lose");
                    totalCost--;
                    Console.WriteLine("you left cost " + totalCost);
                }
            }
        }
    }
}
