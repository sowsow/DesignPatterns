namespace StructuralPatterns.Adapter
{
    // The Adaptee contains some useful behavior,
    // but its interface is incompatible with the existing client code.
    // The Adaptee needs adaptation before the client code can use it
    public class Adaptee : IAdaptee
    {
        public string GetSpecificRequest()
        {
            return "Specific Request from incompatible class - Adaptee";
        }
    }
}
