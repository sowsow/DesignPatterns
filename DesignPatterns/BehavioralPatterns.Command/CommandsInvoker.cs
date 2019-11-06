using System;
using BehavioralPatterns.Command.Commands;

namespace BehavioralPatterns.Command
{
    // The Invoker is associated one or several commands
    // It send a request to the command
    public class CommandsInvoker
    {
        private ICommand _onStart;

        private ICommand _onFinish;

        public void SetOnStart(ICommand command)
        {
            _onStart = command;
        }

        public void SetOnFinish(ICommand command)
        {
            _onFinish = command;
        }

        // The Invoker does not depend on concrete Command object or Receiver object
        // The Invoker passes a request to a Receiver indirectly
        // via executing a command
        public void DoSomethingImportant()
        {
            Console.WriteLine("Commands Invoker: OnStart...");
            _onStart?.Execute();

            Console.WriteLine("Commands Invoker: Doing super important things...");

            Console.WriteLine("Commands Invoker: OnFinish...");
            _onFinish?.Execute();
        }
    }
}
