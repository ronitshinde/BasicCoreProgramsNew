using System;

namespace BasicsCorePrograms
{
    public class SwapTwoNumbers
    {
        public void SwapNumbers()
        {
            Console.WriteLine("Enter value of a");
            int a = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter value of b");
            int b = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Value before swap a = " + a + ", b = " + b);
            a = a * b;
            b = a / b;
            a = a / b;
            Console.WriteLine("Value after swap a = " + a + ", b = " + b);
        }
    }
}
