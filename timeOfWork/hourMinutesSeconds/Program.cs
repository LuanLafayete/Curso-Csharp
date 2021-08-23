using System;

namespace hourMinutesSeconds
{
    class Program
    {
        static void Main(string[] args)
        {
            int time, hour, resto01, resto02, minutes;

            Console.Write("How many minutes did you work in this project? ");
            time = int.Parse(Console.ReadLine());

            hour = time / 3600;
            resto01 = time % 3600;

            minutes = resto01 / 60;
            resto02 = resto01 % 60;

           
            Console.WriteLine("I worked: " + hour + ":" + minutes + ":" + resto02);


        }
    }
}
