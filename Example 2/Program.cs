using System;
using System.Threading;
using System.Threading.Tasks;

namespace Asynchronous_Programming_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Methods();
            Console.ReadLine();
        }
        static void Methods()
        {
            MethodSample();
            Method3();
        }

        async static void MethodSample()
        {
            var result2 = await Task.Run(() =>
            {
                return Method1();
            });
            Method2(result2);
        }

        static int Method1()
        {
            Thread.Sleep(3000);
            Console.WriteLine("Method 1 Called");
            return 10;
        }
        static int Method2(int result)
        {
            Console.WriteLine("Method 2 Called");
            return result*2;
        }
        static int Method3()
        {
            Console.WriteLine("Method 3 Called");
            return 2;
        }
    }
}
