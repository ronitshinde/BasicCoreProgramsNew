using System;
using System.Runtime.Remoting.Metadata.W3cXsd2001;

namespace BasicsCorePrograms
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("1.FlipCoin \n2.LeapYear ");
            Console.WriteLine("Enter a option");
            int option = Convert.ToInt32(Console.ReadLine());
            switch (option)
            {
                case 1:
                    FlipCoins flip = new FlipCoins();
                    flip.Coin();
                    Console.ReadLine();
                    break;
                case 2:
                    LeapYear year = new LeapYear();
                    year.Leap();
                    Console.ReadLine();
                    break;
            }
        }
    }
}
