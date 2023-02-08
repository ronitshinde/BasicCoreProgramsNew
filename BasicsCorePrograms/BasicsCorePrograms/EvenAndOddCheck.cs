using System;

namespace BasicsCorePrograms
{
    public class EvenAndOddCheck
    {
        public void EvenOdd()
        {
            int a, b = 2, c ;

            Console.WriteLine("Enter the Number");
            a = Convert.ToInt32(Console.ReadLine());
            c = a % b;

            if (c == 0)
            {
                Console.WriteLine("Number is Even : " + a);
            }
            else
            {
                Console.WriteLine("Number is odd : " + a);
            }
        }
    }
}
