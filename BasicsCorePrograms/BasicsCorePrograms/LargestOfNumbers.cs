using System;

namespace BasicsCorePrograms
{
    public class LargestOfNumbers
    {
        public void Largestnum()
        {
            int numOne, numTwo, numThree;

            Console.WriteLine("Print the greatest number of 3 numbers");

            Console.WriteLine("Enter the 1st number");
            numOne = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter the 2nd number");
            numTwo = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter the 3rd number");
            numThree = Convert.ToInt32(Console.ReadLine());

            if (numOne > numTwo)
            {
                if (numOne > numThree)
                {
                    Console.WriteLine("Number 1st is greater : " + numOne);
                }
                else
                {
                    Console.WriteLine("Number 3rd is greater : " + numThree);
                }
            }
            else if (numTwo > numThree)
            {
                Console.WriteLine("Number 2nd is greater : " + numTwo);
            }
            else
            {
                Console.WriteLine("Number 3rd is greater : " + numThree);
            }
        }
    }
}
