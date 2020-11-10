using System;

namespace Day_20_AddressBook
{
    class Program
    {
            AddressBook book;
            /// <summary>
            /// Initializes a new instance of the <see cref="Program"/> class.
            /// </summary>
            public Program()
            {
                    book = new AddressBook();
            }

            /// <summary>
            /// Defines the entry point of the application.
            /// </summary>
            /// <param name="args">The arguments.</param>
            static void Main(string[] args)
            {
                //creation of object
                Program p = new Program();
                Console.WriteLine("Hello, Welcome to Address Book!");
                Console.WriteLine("Enter the person details to be added in the address book");
                Console.WriteLine("First Name");
                string FirstName = Console.ReadLine();
                Console.WriteLine("Last Name");
                string LastName = Console.ReadLine();
                Console.WriteLine("Address");
                string Address = Console.ReadLine();
                Console.WriteLine("City");
                string City = Console.ReadLine();
                Console.WriteLine("State");
                string State = Console.ReadLine();
                Console.WriteLine("Zip code");
                string ZipCode = Console.ReadLine();
                Console.WriteLine("Phone Number");
                string PhoneNumber = Console.ReadLine();
                Console.WriteLine("Email");
                string Email = Console.ReadLine();
                //addition of contacts
                if (p.book.AddContact(FirstName, LastName, Address, City, State, ZipCode, PhoneNumber, Email) == true)
                {
                    Console.WriteLine("Contact added successfully");
                }
                else
                {
                    Console.WriteLine("Contact already exists");
                }
            }
        }
    }