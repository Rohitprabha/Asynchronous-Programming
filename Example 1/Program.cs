using System;
using System.Threading;
using System.Threading.Tasks;

namespace Asynchronous_programming
{
    class Program
    {
        static void Main(string[] args)
        {
            Methods();
            Console.ReadLine();
        }
        async static void Methods()
        {
            var result1 = await Task.Run(() => Method2());
            Task.Run(() =>
            {
                Method1();
            });
            //Task.Run(() =>
            //{
            //    Method2();
            //});
            Task.Run(() =>
            {
                Method3();
            });
        }
        static int Method1()
        {
            Thread.Sleep(3000);
            Console.WriteLine("Method 1 Called");
            return 0;
        }
        static int Method2()
        {
            Console.WriteLine("Method 2 Called");
            return 0;
        }
        static int Method3()
        {
            Console.WriteLine("Method 3 Called");
            return 0;
        }
    }
}
