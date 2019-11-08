using System.Collections;

namespace BehavioralPatterns.Iterator.Iterators
{
    /// <summary>
    /// Customized Iterators should inherit this Abstract Iterator
    /// </summary>
    public abstract class Iterator : IEnumerator
    {
        object IEnumerator.Current => Current();

        // Returns the KEY of the current element
        public abstract int Key();

        // Returns the CURRENT element
        public abstract object Current();

        // Move forward to the NEXT element
        public abstract bool MoveNext();

        // Rewinds the current Iterator to the FIRST element
        public abstract void Reset();
    }
}
