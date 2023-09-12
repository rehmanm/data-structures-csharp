using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructures.Structures.Misc
{
    public class DictionaryTest
    {

        private readonly Dictionary<int, int> _dictionary;

        public DictionaryTest()
        {
            _dictionary = new Dictionary<int, int>();

        }

        public void Add(int key)
        {
            if (_dictionary.TryGetValue(key, out int value))
            {
                _dictionary[key] = value + 1;
            } else
            {
                _dictionary[key] = 0;
            }
        }

        public int GetValue(int key)
        {
            if (_dictionary.TryGetValue(key, out int value))
            {
                return value;
            } 
            return 0;
        }

        public int GetElementAt(int position)
        {
            return _dictionary.ElementAtOrDefault(position).Value;
        }
    }
}
