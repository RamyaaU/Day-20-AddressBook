﻿using System;

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
            //using loop as variant
            bool loop = true;
            while (loop)
            {
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
                        //calling addcontact function
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
                    case 2:
                        Console.WriteLine("Enter the first name of the contact to be edited ");
                        string name = Console.ReadLine();
                        Contact c = p.book.FindContact(name);
                        if (c == null)
                        {
                            Console.WriteLine("Address for {0} count not be found.", name);
                            break;
                        }
                        else
                        {
                            Console.WriteLine("New Last Name");
                            c.LastName = Console.ReadLine();
                            Console.WriteLine("New Address");
                            c.Address = Console.ReadLine();
                            Console.WriteLine("New City");
                            c.City = Console.ReadLine();
                            Console.WriteLine("New State");
                            c.State = Console.ReadLine();
                            Console.WriteLine("New Zip code");
                            c.ZipCode = Console.ReadLine();
                            Console.WriteLine("New Phone Number");
                            c.PhoneNumber = Console.ReadLine();
                            Console.WriteLine("New Email");
                            c.Email = Console.ReadLine();
                            Console.WriteLine("Details updated for " + name);
                            break;
                        }
                    case 3:
                        loop = false;
                        break;
                }
            }
        }
    }
}
