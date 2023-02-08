using System;

namespace BasicsCorePrograms
{
    public class QuotientAndRemainder
    {
        public void QuoAndRem()
        {
            Console.WriteLine("Enter the value of dividend");
            int dividend = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter the value of divisor");
            int divisor = Convert.ToInt32(Console.ReadLine());

            double quotient = (dividend / divisor);
            double remainder = (dividend % divisor);

            //Console.WriteLine("Dividend : {0} Divisor : {1}" ,dividend,divisor);
            Console.WriteLine("Dividend : " + dividend + " and Divisor : " + divisor);

            Console.WriteLine("Quotient = " + quotient);
            Console.WriteLine("Remainder = " + remainder);

        }
    }
}
