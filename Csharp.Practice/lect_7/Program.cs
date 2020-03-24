using System;

namespace lect_7
{
    class Program
    {
        static void Task1()
        {
            int[] arrayTask1 = new int[0];
        }

        static void Task2()
        {
            object[] arrayTask2 = new object[3];

            arrayTask2[0] = 32;
            arrayTask2[1] = 'A' ;
            arrayTask2[2] = "Hello";

            for (int i = 0; i < arrayTask2.Length; i++)
            {
                Console.WriteLine(arrayTask2[i]);
            }

            arrayTask2[0] = (int)arrayTask2[0] + 10;

            arrayTask2[2] += " guys!";

            for (int i = 0; i < arrayTask2.Length; i++)
            {
                Console.WriteLine(arrayTask2[i]);
            }


        }

        static void Task3()
        {
            int maxValue = 0;
            Random random = new Random();
            int[] arrayTask3 = new int[50];
            for (int i = 0; i < arrayTask3.Length; i++)
            {
                arrayTask3[i] = random.Next(1,10);
            }

            for (int i = 0; i < arrayTask3.Length; i++)
            {
                if (arrayTask3[maxValue]<arrayTask3[i])
                {
                    maxValue = i;
                }
            }
            Console.WriteLine($"Максимальное значение { arrayTask3[maxValue]}");
        }



        static void Main(string[] args)
        {
            Task1();
            Task2();
            Task3();
        }
    }
}
