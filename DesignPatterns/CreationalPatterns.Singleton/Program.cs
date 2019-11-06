using System;
using System.Threading;

namespace CreationalPatterns.Singleton
{
    public class Program
    {
        /// <summary>
        /// Singleton is a creational design pattern,
        /// which ensures that only one object of its kind exists and provides a single point of access to it for any other code.
        /// </summary>
        /// <param name="args"></param>
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
