using System;

namespace BasicsCorePrograms
{
    public class FlipCoins
    {
        int countHead = 0;
        int countTail = 0;
        public void Coin()
        {
            Console.WriteLine("Enter the number of times to flip the coin");
            int flipNum = Convert.ToInt32(Console.ReadLine());

            Random random = new Random();
            for (int i = 0; i < flipNum; i++)
            {
                double numCheck = random.NextDouble();
                if (numCheck > 0.5)
                    countHead++;
                else
                    countTail++;
            }
            Console.WriteLine("Count of Head : " + countHead);
            Console.WriteLine("Count of Tail : " + countTail);

            float headPercentage = (float)countHead / flipNum * 100;
            float tailPercentage = (float)countTail / flipNum * 100;

            Console.WriteLine("Percentage of head : " + headPercentage);
            Console.WriteLine("Percentage of tail : " + tailPercentage);
        }
    }
}
   
