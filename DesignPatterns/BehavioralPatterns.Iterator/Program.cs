using System;
using BehavioralPatterns.Iterator.Models;

namespace BehavioralPatterns.Iterator
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("BehavioralPatterns.Iterator");

            // The client code may or may not know about the Concrete Iterator
            // or Collection Classes, depending on the level of indication
            // that you want to keep in your program
            var collection = new WordsCollection();
            
            collection.AddItems("First");
            collection.AddItems("Second");
            collection.AddItems("Third");

            Console.WriteLine("Straight Traversal:");

            foreach (var element in collection)
            {
                Console.WriteLine(element);
            }

            Console.WriteLine($"{Environment.NewLine}Reverse Traversal: ");

            collection.ReverseDirection();

            foreach (var element in collection)
            {
                Console.WriteLine(element);
            }
        }
    }
}
