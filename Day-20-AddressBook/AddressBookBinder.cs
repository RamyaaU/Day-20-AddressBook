using System;
using System.Collections.Generic;
using System.Text;

namespace Day_20_AddressBook
{
    class AddressBookBinder
    {
        //creating dictionary to store contacts passing hashset as an arguement
        public Dictionary<string, HashSet<Contact>> Binder = new Dictionary<string, HashSet<Contact>>();

        /// <summary>
        /// Adds the addr book.
        /// </summary>
        /// <param name="key">The key.</param>
        /// <param name="set">The set.</param>
        /// <returns></returns>
        public HashSet<Contact> AddAddrBook(string key, HashSet<Contact> set)
        {
            if (this.Binder.ContainsKey(key))
            {
                Console.WriteLine("Address book already exists");
                return Binder[key];
            }
            else
            {
                Console.WriteLine("New address book created");
                Binder.Add(key, set);
                return Binder[key];
            }
        }
    }
}
    

