using System;

namespace BasicsCorePrograms
{
    public class HarmonicNumber
    {
        public void Harmonic()
        {
            int i, n;
            double s = 0;
            Console.WriteLine("Calculate the harmonic series and their sum: ");
            Console.Write("\n");
            Console.WriteLine("Input the number of terms : ");

            n = Convert.ToInt32(Console.ReadLine());
            for (i = 1; i <= n; i++)
            {
                Console.Write("1/{0} + ", i);
                s += 1 / (float)i;
            }
            Console.WriteLine("\nSum of Series upto {0} terms : {1} ", n, s);
        }
    }
}
