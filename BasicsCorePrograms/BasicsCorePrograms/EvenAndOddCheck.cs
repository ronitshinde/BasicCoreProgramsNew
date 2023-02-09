using System;

namespace BasicsCorePrograms
{
    public class EvenAndOddCheck
    {
        public void EvenOdd()
        {
            int numOne, numTwo = 2, num ;

            Console.WriteLine("Enter the Number");
            numOne = Convert.ToInt32(Console.ReadLine());
            num = numOne % numTwo;

            if (num == 0)
            {
                Console.WriteLine("Number is Even : " + numOne);
            }
            else
            {
                Console.WriteLine("Number is odd : " + numOne);
            }
        }
    }
}
