using System;

namespace lect._5Greeting
{
    class Program
    {
        static void Main(string[] args)
        {
            TimeSpan ttimeNow = DateTime.Now.TimeOfDay;


            int timeNow = ttimeNow.Hours;
            //TimeSpan.FromHours
            if (timeNow >= 9 && timeNow < 12)
            {
                Console.WriteLine("Good morning gays");
            }
            else if (timeNow >= 12 && timeNow < 15)
            {
                Console.WriteLine("Good day gays");
            }
            else if(timeNow >= 15 && timeNow < 22)
            {
                Console.WriteLine("Good evening gays");
            }
            
        }
    }
}
