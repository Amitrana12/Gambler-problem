using System;

namespace gambler
{
   public class Program
    {
        public static  int TOTAL_COST = 100;
        public static  int BET_COST = 1;
        public static int day = 20;
        public static int tottalAmout20daywin = 0;
        public static int tottalAmout20daylose = 0;
        public static int tottalbet20dayWin = 0;
        public static int tottalbet20daylose = 0;



        static void Main(string[] args)
        {
            for (int i = 1; i <= day; i++)
            { 
                winOrLose();
                day--;
                tottalAmout20daywin += tottalAmout20daywin;
                tottalAmout20daylose += tottalAmout20daylose;
                tottalbet20dayWin += tottalbet20dayWin;
                tottalbet20daylose += tottalbet20daylose;
                    
            }
            Console.WriteLine("total amout for 20 day win " + tottalAmout20daywin);
            Console.WriteLine("total amout for 20 day win " + tottalAmout20daylose);
            Console.WriteLine("totall 20 day win bet=" + tottalbet20dayWin);
            Console.WriteLine("total 20 losee bet=" + tottalbet20daylose);
        }




        public static void winOrLose()
        {
            int dayCost = TOTAL_COST;
            int betCostOnce = BET_COST;
            int totalBetADay = 0;
            
            while (dayCost != 150 && dayCost != 50)
            {
                Random random = new Random();
                int Check = random.Next(0, 2);
                totalBetADay++;
                if (Check == 1 && betCostOnce == 1 )
                {
                   // Console.WriteLine("you win");
                    dayCost++;
                    tottalbet20dayWin++;
                    tottalAmout20daywin++;
                   // Console.WriteLine("you left cost " + dayCost);
                }
                else
                {
                    //Console.WriteLine("you lose");
                    dayCost--;
                    tottalbet20daylose++;
                    tottalAmout20daylose++;
        
                    //Console.WriteLine("you left cost " + dayCost);
                }
               
            }

           
        }
    }
}
