using System;
using System.Collections;

namespace TASK2
{
    class Program
    {
        static void Main(string[] args)
        {
            ArrayList arrayList = new ArrayList();
            arrayList.Add(45); 
            arrayList.Add(true);
            arrayList.Add("hello");
            arrayList.Add(24.45);
            foreach(object list in arrayList)
            {
                Console.WriteLine(list.GetType());
            }
        }
    }
}
