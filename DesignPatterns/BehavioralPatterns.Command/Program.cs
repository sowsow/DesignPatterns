using System;
using BehavioralPatterns.Command.Commands;

namespace BehavioralPatterns.Command
{
    public class Program
    {
        /// <summary>
        /// Command is behavioral design pattern,
        /// which converts requests or simple operations into objects.
        /// </summary>
        /// <param name="args"></param>
        public static void Main(string[] args)
        {
            Console.WriteLine("BehavioralPatterns.Command");

            // The Client code can parameterize an invoker with any commands
            var invoker = new CommandsInvoker();
            
            invoker.SetOnStart(new SimpleCommand("Hi~"));
            
            var complexCommand = new ComplexCommand(
                new BusinessLogicCommandReceiver(),
                "Send Email",
                "Save Report");

            invoker.SetOnFinish(complexCommand);

            // Fire
            invoker.DoSomethingImportant();
        }
    }
}
