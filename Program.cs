using System;
using System.Threading.Tasks;

namespace Demo_Asyn_Await
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Demo Asyn<task> and Await<task> keyword");
            Method1();
            Method2();
            Console.ReadKey();

        }
        public static async Task Method1()
        {
            await Task.Run(() =>
            {
                for (int i = 0; i < 100; i++)
                {
                    Console.WriteLine("Method1");
                    Task.Delay(100).Wait();

                }
            });

        }
        public static void Method2()
        {
            for(int i=0;i<25;i++)
            {
                Console.WriteLine("Method2");
                Task.Delay(100).Wait();
            }
        }
    }
}
