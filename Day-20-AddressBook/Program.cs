using System;

namespace Day_20_AddressBook
{
    class Program
    {
        /// <summary>
        /// Defines the entry point of the application.
        /// </summary>
        /// <param name="args">The arguments.</param>
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, Welcome to Address Book");
            //reference for addressbook class
            AddressBook addressBook = new AddressBook();
            //contact details
            addressBook.AddContact("Ramya", "U", "Indiranagar", "Bangalore", "Karnataka", "ramya@gmail.com", 567890, 9988774455);
            //for displaying contact
            addressBook.ViewContact();
        }
    }
}
