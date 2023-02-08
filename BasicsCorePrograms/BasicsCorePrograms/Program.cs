using System;

namespace BasicsCorePrograms
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("1.FlipCoin \n2.LeapYear \n3.PowerOfTwo \n4.HarmonicNumber \n5.QuotientAndRemainder \n6.SwapTwoNumbers \n7.EvenAndOddCheck");
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
                case 3:
                    PowerOfTwo two = new PowerOfTwo();
                    two.Power();
                    Console.ReadLine();
                    break;
                case 4:
                    HarmonicNumber num = new HarmonicNumber();
                    num.Harmonic();
                    Console.ReadLine();
                    break;
                case 5:
                    QuotientAndRemainder calculate = new QuotientAndRemainder();
                    calculate.QuoAndRem();
                    Console.ReadLine();
                    break;
                case 6:
                    SwapTwoNumbers swap = new SwapTwoNumbers();
                    swap.SwapNumbers();
                    Console.ReadLine();
                    break;
                case 7:
                    EvenAndOddCheck check = new EvenAndOddCheck();
                    check.EvenOdd();
                    Console.ReadLine();
                    break;
            }
        }
    }
}
