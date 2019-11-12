namespace StructuralPatterns.Adapter
{
    // Adaptee interface that is incompatible with client code
    // May not exist in real scenarios
    public interface IAdaptee
    {
        string GetSpecificRequest();
    }
}
