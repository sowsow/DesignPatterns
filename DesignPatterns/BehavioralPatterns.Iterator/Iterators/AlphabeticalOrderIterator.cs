using BehavioralPatterns.Iterator.Models;

namespace BehavioralPatterns.Iterator.Iterators
{
    /// <summary>
    /// Concrete Iterators implement various traversal algorithms
    /// These Iterator classes store the current traversal position at all times
    /// </summary>
    public class AlphabeticalOrderIterator : Iterator
    {
        private readonly WordsCollection _collection;

        // Stores the current traversal position
        // An iterator may have lots of other fields for storing iteration state
        // Especially when it is supposed to work with a particular kind of collection
        private int _position = -1;

        private readonly bool _reverse;

        public AlphabeticalOrderIterator(WordsCollection collection, bool reverse = false)
        {
            _collection = collection;
            _reverse = reverse;

            if (_reverse)
            {
                _position = _collection.GetItems().Count;
            }
        }

        public override int Key()
        {
            return _position;
        }

        public override object Current()
        {
            return _collection.GetItems()[_position];
        }

        public override bool MoveNext()
        {
            var updatedPosition = _position + (_reverse ? -1 : 1);

            if (updatedPosition >= 0 && updatedPosition < _collection.GetItems().Count)
            {
                _position = updatedPosition;

                return true;
            }

            return false;
        }

        public override void Reset()
        {
            _position = _reverse
                ? _collection.GetItems().Count - 1
                : 0;
        }
    }
}
