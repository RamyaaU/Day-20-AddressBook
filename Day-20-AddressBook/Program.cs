using System;

namespace Day_20_AddressBook
{
    class Program
    {
        //declaration
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
            //welcome message
            Console.WriteLine("Hello, Welcome to Address Book!");
            //main menu
            Console.WriteLine("Select the option. \n1. Add new contact. \n2. Edit existing contact. \n3. Exit.");
                int option = int.Parse(Console.ReadLine());
                switch (option)
                {
                    case 1:
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
                        //calling AddContact function
                        if (p.book.AddContact(FirstName, LastName, Address, City, State, ZipCode, PhoneNumber, Email))
                        {
                            Console.WriteLine("Contact added successfully");
                            break;
                        }
                        else
                        {
                            Console.WriteLine("Contact already exists");
                            break;
                        }
                }
            }
        }
    }
