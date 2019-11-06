using System;
using System.Threading;

namespace CreationalPatterns.Singleton
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("CreationalPatterns.Singleton");

            var processOne = new Thread(() =>
            {
                TestSingleton("Rex");
            });

            var processTwo = new Thread(() =>
            {
                TestSingleton("Li");
            });

            processOne.Start();
            processTwo.Start();

            processOne.Join();
            processTwo.Join();
        }

        private static void TestSingleton(string value)
        {
            var singletonTarget = SingletonService.GetConfigurationServiceSingleton(value);

            singletonTarget.DoSomething();
        }
    }
}
