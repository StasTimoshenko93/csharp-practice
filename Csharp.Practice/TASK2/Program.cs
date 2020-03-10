using System;
using System.Collections;

namespace TASK2
{
    class Program
    {
        static void Main(string[] args)
        {
            //используется параметр типа object, Я не внимательно прочитал задание, поэтому не указал  в виде коментария
            // но, при выполнении задания, когда использовал метод foreach, то там указан тип. => object list

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
