using System;

namespace BasicsCorePrograms
{
    public class VowelsAndConsonants
    {
        public void Alphabet()
        {
            Console.WriteLine("Enter any Character : ");

            char word = Convert.ToChar(Console.ReadLine());

            if (word == 'a' || word == 'e' || word == 'i' || word == 'o' || word == 'u' ||
                  word == 'A' || word == 'E' || word == 'I' || word == 'O' || word == 'U')
            {
                Console.WriteLine(word + " Alphabet is vowels ");
            }
            else if ((word >= 'a' && word <= 'z') || (word >= 'A' && word <= 'Z'))
            {
                Console.WriteLine(word + " Alphabet is Consonant ");
            }
        }
    }
}
