using System;
using System.Collections.Generic;
using System.Text;

namespace Day_20_AddressBook
{
    class AddressBookBinder
    {
        public Dictionary<string, HashSet<Contact>> Binder = new Dictionary<string, HashSet<Contact>>();
        //creates a list 
        public List<Contact> City = new List<Contact>();
        //create a dictionary
        public Dictionary<string, List<Contact>> CityDictionary = new Dictionary<string, List<Contact>>();

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

        /// <summary>
        /// Sorts the by city.
        /// </summary>
        /// <param name="cityname">The cityname.</param>
        /// <returns></returns>
        public List<Contact> SortByCity(string cityname)
        {
            foreach (var key in Binder.Keys)
            {
                foreach (Contact c in Binder[key])
                {
                    if (c.City == cityname)
                        City.Add(c);
                }
            }
            return City;
        }

        /// <summary>
        /// Searches the contacts by city.
        /// </summary>
        /// <param name="city">The city.</param>
        /// <returns></returns>
        public List<Contact> SearchContactsByCity(string city)
        {
            CityDictionary[city] = SortByCity(city);
            return CityDictionary[city];
        }
    }
}
