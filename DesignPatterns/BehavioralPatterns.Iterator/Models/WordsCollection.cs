using System.Collections;
using System.Collections.Generic;
using BehavioralPatterns.Iterator.Iterators;

namespace BehavioralPatterns.Iterator.Models
{
    /// <summary>
    /// Concrete collections provide one or several methods for
    /// retrieving fresh iterator instance
    /// compatible with the collection class
    /// </summary>
    public class WordsCollection : IteratorAggregate
    {
        private readonly List<string> _collection = new List<string>();

        private bool _direction;

        public override IEnumerator GetEnumerator()
        {
            return new AlphabeticalOrderIterator(this, _direction);
        }

        public void ReverseDirection()
        {
            _direction = !_direction;
        }

        public List<string> GetItems()
        {
            return _collection;
        }

        public void AddItems(string item)
        {
            _collection.Add(item);
        }
    }
}
