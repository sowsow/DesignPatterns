using System;

namespace BehavioralPatterns.Command.Commands
{
    /// <summary>
    /// Some commands that can implement simple operations on their own
    /// </summary>
    public class SimpleCommand : ICommand
    {
        private readonly string _payLoad;

        public SimpleCommand(string payLoad)
        {
            _payLoad = payLoad;
        }

        public void Execute()
        {
            Console.WriteLine($"Simple Command Execution: Print [{_payLoad}]");
        }
    }
}
