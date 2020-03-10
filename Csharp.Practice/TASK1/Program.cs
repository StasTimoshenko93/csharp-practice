using System;

namespace TASK1
{
    class Program
    {
        static void Main(string[] args)
        {
            short value = 5;
            object valueO = value;
            sbyte valueB = (sbyte)value;

            Console.WriteLine($"Type :{valueB.GetType()}, Value {valueB} ");


        }
    }
}
