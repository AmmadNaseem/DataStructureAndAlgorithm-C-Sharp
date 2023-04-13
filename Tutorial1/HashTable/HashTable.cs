using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Tutorial1.HashTable
{
    internal class HashTable
    {
        public string[] _hashTable { get; set; }
        public HashTable()
        {
            _hashTable=new string[10];
        }

        //This is a very very weak hashing algorithm
        //This is a simple and common hash function that maps a given key to a slot in the hash table.

        //The resulting integer value represents the index of the slot in the hash table where the key-value pair should be stored or retrieved.
        //The slot is determined based on the modulo operation, which ensures that the hash value is within the bounds of the hash table size.
        private int _hash(string key)
        {
            return key.Length % _hashTable.Length; // module make shower that we are not going over the array length. 
        }
        public string Get(string key)
        {
            int hashedKey = _hash(key);
            return _hashTable[hashedKey];
        }

        public void Set(string key,string value)
        {
            //key is going to be hashed
            int hashedKey=_hash(key);
            if (_hashTable[hashedKey]!=null)
            {
                Console.WriteLine("Sorry, hash collision has occured.");
            }
            else
            {
                _hashTable[hashedKey] = value;
            }
        }
    }
}
