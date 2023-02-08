using System;

namespace BasicsCorePrograms
{
    public class PowerOfTwo
    {
        public void Power()
        {
            Console.WriteLine("Enter the power");
            int powerNum = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();
            Console.WriteLine("Table for power of 2 ^ {0}" ,powerNum);

            for (int i = 1; i < powerNum; i++)
            {
                int table = (int)Math.Pow(2, i);
                Console.WriteLine(table);
            }
        }
    }
}
