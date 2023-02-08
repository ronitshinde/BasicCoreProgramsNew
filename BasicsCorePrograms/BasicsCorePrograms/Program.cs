using System;

namespace BasicsCorePrograms
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("1.FlipCoin");
            Console.WriteLine("Enter a option");
            int option = Convert.ToInt32(Console.ReadLine());
            switch (option)
            {
                case 1:
                    FlipCoins flip = new FlipCoins();
                    flip.Coin();
                    Console.ReadLine();
                    break;
            }
        }
    }
}
