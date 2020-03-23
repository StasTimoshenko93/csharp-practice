using System;

namespace lect._5LetterA
{
    class Program
    {
        static void Main(string[] args)
        {
            string inputWorld = Console.ReadLine();
            int count = 0;
            foreach(var letter in inputWorld)
            {
                if ( letter == 'a')
                {
                    count += 1;
                }
            }
            Console.WriteLine(count);
        }
    }
}
