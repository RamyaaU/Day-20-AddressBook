using System;
using System.Collections.Generic;
using System.Text;

namespace Day_20_AddressBook
{
    interface IContact
    {
        /// <summary>
        /// Adds the contact.
        /// </summary>
        /// <param name="firstName">The first name.</param>
        /// <param name="lastName">The last name.</param>
        /// <param name="address">The address.</param>
        /// <param name="city">The city.</param>
        /// <param name="state">The state.</param>
        /// <param name="email">The email.</param>
        /// <param name="zip">The zip.</param>
        /// <param name="phoneNumber">The phone number.</param>
        public void AddContact(string firstName, string lastName, string address, string city, string state, string email, int zip, long phoneNumber);

        /// <summary>
        /// Views the contact.
        /// </summary>
        /// <param name="name">The name.</param>
        public void ViewContact(string name);

        /// <summary>
        /// Edits the contact.
        /// </summary>
        /// <param name="name">The name.</param>
        public void EditContact(string name);

        /// <summary>
        /// Deletes the contact.
        /// </summary>
        /// <param name="name">The name.</param>
        public void DeleteContact(string name);
    }
}
