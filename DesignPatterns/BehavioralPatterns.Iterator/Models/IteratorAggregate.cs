using System.Collections;

namespace BehavioralPatterns.Iterator.Models
{
    /// <summary>
    /// Customized Collections should inherit this Abstract IteratorAggregate
    /// </summary>
    public abstract class IteratorAggregate : IEnumerable
    {
        public abstract IEnumerator GetEnumerator();
    }
}
