using System;

namespace BasicsCorePrograms
{
    public class LargestOfNumbers
    {
        public void Largestnum()
        {
            int num1, num2, num3;

            Console.WriteLine("Print the greatest number of 3 numbers");

            Console.WriteLine("Enter the 1st number");
            num1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter the 2nd number");
            num2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter the 3rd number");
            num3 = Convert.ToInt32(Console.ReadLine());

            if (num1 > num2)
            {
                if (num1 > num3)
                {
                    Console.WriteLine("Number 1st is greater : " + num1);
                }
                else
                {
                    Console.WriteLine("Number 3rd is greater : " + num3);
                }
            }
            else if (num2 > num3)
            {
                Console.WriteLine("Number 2nd is greater : " + num2);
            }
            else
            {
                Console.WriteLine("Number 3rd is greater : " + num3);
            }
        }
    }
}
