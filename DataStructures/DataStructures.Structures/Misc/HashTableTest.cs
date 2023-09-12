using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructures.Structures.Misc
{
    public class HashTableTest
    {
        private readonly Hashtable _hashtable;

        public HashTableTest()
        {
            _hashtable = new Hashtable();
        }

        public void Add(object key)
        {
            _hashtable.Add(key, key);
        }
        public object? GetValue(object key)
        {
            return _hashtable[key];             
        }

 
    }
}
