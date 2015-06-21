using System.Threading.Tasks;

namespace _03AsynchronousTimer
{
    #region

    using System;

    #endregion

    internal class TimerTest
    {
        public static void Main(string[] args)
        {
            AsynchronousTimer timer = new AsynchronousTimer(Print, 1000, 10);
            timer.Start();

            AsynchronousTimer timer2 = new AsynchronousTimer(Print2, 2000, 10);
            timer2.Start();

            string input = Console.ReadLine();
            while (input != "end")
            {
                input = Console.ReadLine();
            }
            Task.WaitAll(timer.Task, timer2.Task);
        }

        public static void Print()
        {
            Console.WriteLine("Working...");
        }

        public static void Print2()
        {
            Console.WriteLine("Timer2 also working");
        }

    }
}