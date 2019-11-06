namespace BehavioralPatterns.Command.Commands
{
    /// <summary>
    /// Some commands that can delegate more complex operations
    /// to other objects, called "Receivers"
    /// </summary>
    public class ComplexCommand : ICommand
    {
        private readonly BusinessLogicCommandReceiver _businessLogicCommandReceiver;

        // Context date, required for invoking the Receiver's methods
        private readonly string _payLoadA;

        private readonly string _payLoadB;

        // Complex command can accept one or several receiver objects
        // along with any context data via the constructor
        public ComplexCommand(
            BusinessLogicCommandReceiver businessLogicCommandReceiver,
            string payLoadA,
            string payLoadB)
        {
            _businessLogicCommandReceiver = businessLogicCommandReceiver;
            _payLoadA = payLoadA;
            _payLoadB = payLoadB;
        }

        // Commands can delegate to any methods of a Receiver
        // where heavy lifting logic is implemented
        public void Execute()
        {
            _businessLogicCommandReceiver.DoSomeComplexThing(_payLoadA);
            _businessLogicCommandReceiver.DoSomeOtherComplexThing(_payLoadB);
        }
    }
}
