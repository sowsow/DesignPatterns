using System;

namespace BehavioralPatterns.Command
{
    /// <summary>
    /// The Receiver classes contain important business logic
    /// They know how to perform all kinds of operations,
    /// associated with carrying out a request.
    /// Any classes can serve as a Receiver.
    /// </summary>
    public class BusinessLogicCommandReceiver
    {
        public BusinessLogicCommandReceiver()
        {
        }

        public void DoSomeComplexThing(string value)
        {
            Console.WriteLine($"Business Logic Receiver Execution: Print [{value}]");
        }

        public void DoSomeOtherComplexThing(string value)
        {
            Console.WriteLine($"Business Logic Receiver Other Execution: Print [{value}]");
        }
    }
}
