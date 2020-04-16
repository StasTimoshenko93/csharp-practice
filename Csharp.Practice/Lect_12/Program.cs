using System;

namespace Lect_12
{
    class Program
    {
        static void Main(string[] args)
        {
            UnigueItem item = new UnigueItem();
            Console.WriteLine(UnigueItem.Id);
            UnigueItem item1 = new UnigueItem();
            Console.WriteLine(UnigueItem.Id);
            UnigueItem item2 = new UnigueItem();
            Console.WriteLine(UnigueItem.Id);
            UnigueItem item3 = new UnigueItem(5);
            UnigueItem item4 = new UnigueItem(6);
            Console.WriteLine(UnigueItem.Id);
        }
    }
}
