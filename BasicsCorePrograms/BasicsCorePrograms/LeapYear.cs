using System;

namespace BasicsCorePrograms
{
    public class LeapYear
    {
        public void Leap()
        {
            Console.WriteLine("Enter the year");
            int year = Convert.ToInt32(Console.ReadLine());

            if ((year % 4 == 0 && year % 100 == 0) || year % 100 == 0)
                Console.WriteLine("It is a leap year");
            else
                Console.WriteLine("It is not a leap year");

        }

    }
}

    