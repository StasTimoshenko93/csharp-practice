using System;
using System.Collections;

namespace TASK2
{
    class Program
    {
        static void Main(string[] args)
        {
            ArrayList arrayList = new ArrayList();
            arrayList.Add(45); //boxing
            arrayList.Add(true);//boxing
            arrayList.Add("hello");//false
            arrayList.Add(24.45);//boxing
            foreach(object list in arrayList)
            {
                Console.WriteLine(list.GetType());
            }
        }
    }
}
