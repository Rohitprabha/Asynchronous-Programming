using System;
using System.Threading;
using System.Threading.Tasks;

namespace Asynchronous_Programming_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Method1();
            Method2();
            Console.ReadKey();
        }

        public static async Task Method1()
        {
            await Task.Run(() =>
            {
                for (int i = 0; i < 5; i++)
                {
                    Console.WriteLine(" Method 1");
                    Thread.Sleep(3000);
                }
            });
        }


        public static void Method2()
        {
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine(" Method 2");
                Thread.Sleep(3000);
            }
        }
    }
}
