using System.Collections;
using System.Collections.Generic;

namespace Iterator.GenericImplementation
{
    class WordsCollection : IteratorAggregate
    {
        List<string> _collection = new List<string>();
        
        bool _direction = false;
        
        public void ReverseDirection()
        {
            _direction = !_direction;
        }
        
        public List<string> getItems()
        {
            return _collection;
        }
        
        public void AddItem(string item)
        {
            _collection.Add(item);
        }
        
        public override IEnumerator GetEnumerator()
        {
            return new AlphabeticalOrderIterator(this, _direction);
        }
    }
}