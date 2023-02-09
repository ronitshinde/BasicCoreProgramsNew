using System;

namespace BasicsCorePrograms
{
    public class SwapTwoNumbers
    {
        public void SwapNumbers()
        {
            Console.WriteLine("Enter value of first number");
            int numOne = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter value of second number");
            int numTwo = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Value before swap numOne = " + numOne + ", numTwo = " + numTwo);
            numOne = numOne * numTwo;
            numTwo = numOne / numTwo;
            numOne = numOne / numTwo;
            Console.WriteLine("Value after swap numOne = " + numOne + ", numTwo = " + numTwo);
        }
    }
}
