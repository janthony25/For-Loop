using System;

namespace ForLoop
{
    public class Program
    {
        static void Main(string[] args)
        {

            // for loop

            int maxLvl = 100;
            int lowLvl = 25;
            /*
            for (int i = 0; i <= maxLvl; i+=10)
            {
                Console.WriteLine($"Level up to {i}");
            }
            */

            for (int i = 100; i >= lowLvl; i-=10)
            {
                Console.WriteLine($"Due to PK you are deducted by 10 Level you are now lvl{i}");
            }



            Console.ReadKey();
        }
    }
}