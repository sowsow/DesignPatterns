using System;

namespace StructuralPatterns.Adapter
{
    public class Program
    {
        /// <summary>
        /// Adapter is a structural design pattern,
        /// which allows incompatible objects to collaborate
        /// </summary>
        /// <param name="args"></param>
        public static void Main(string[] args)
        {
            Console.WriteLine("StructuralPatterns.Adapter");
            
            var adaptee = new Adaptee();
            ITarget target = new Adapter(adaptee);

            Console.WriteLine("Adaptee interface is incompatible with the client.");

            Console.WriteLine("But with Adapter client can call Adaptee's method.");

            Console.WriteLine(target.GetRequest());
        }
    }
}
