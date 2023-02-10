using System;

namespace BasicsCorePrograms
{
    public class HarmonicNumber
    {
        public void Harmonic()
        {
            int i, num;
            float sum = 0;
            //float fraction = 0;
            Console.WriteLine("Calculate the harmonic series and their sum: ");
            Console.Write("\n");
            Console.WriteLine("Input the number of terms : ");
            
            num = Convert.ToInt32(Console.ReadLine());
            for (i = 1; i <= num; i++)
            {
                Console.Write("1/{0} + ", i);
                //fraction = ;
                sum += 1 / (float)i;
            }
            Console.WriteLine("\nSum of Series upto {0} terms : {1} ", num, sum);
        }
    }
}
