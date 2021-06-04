using System;
using System.Threading;
using System.Threading.Tasks;

namespace Asynchronous_Programming_Demo
{
    class Program
    {
        static void Main(string[] args)
        {
            Method1();
            Console.WriteLine("Main thread");
            Console.ReadKey();
        }

        public static async void Method1()
        {
            await Task.Run(() => LongTask());
            Console.WriteLine("New Thread");
        }
        public static void LongTask()
        {
            Thread.Sleep(5000);
        }
    }
}
