using System;

namespace TASK1
{
    class Program
    {
        static void Main(string[] args)
        {
            short value = 5;
            object valueO = value;
            sbyte valueB = (sbyte)(short)value;

            Console.WriteLine($"Type :{valueB.GetType()}, Value {valueB} ");


        }
    }
}
