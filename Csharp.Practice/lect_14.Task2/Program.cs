using System;
using System.Collections.Generic;

namespace lect_14.Task2
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Neighbor> floorNeigboors = new List<Neighbor>();
            Neighbor Ivan = new Neighbor("Ivan", 54, "2521924");
            Neighbor Vas9 = new Neighbor("Vasiliy", 60, "1793212");
            floorNeigboors.Add(Ivan);
            floorNeigboors.Add(Vas9);
            Console.WriteLine("Введите номер квартиры");
            int num = ParseInt("Номер");

            for (int i = 0; i < floorNeigboors.Count; i++)
            {
                if (floorNeigboors[i].NFlat == num)
                {
                    Console.WriteLine($" Имя {floorNeigboors[i].Name}  номер телефона: {floorNeigboors[i].Number}");
                }
            }
        }

        public static int ParseInt(string name)
        {
            while (true)
            {
                Console.Write($"Введите {name}: ");
                if (int.TryParse(Console.ReadLine(), out int value))
                {
                    return value;
                }
                else
                {
                    Console.WriteLine($"Неверный формат поля {name}");
                }
            }
        }
    }
}
