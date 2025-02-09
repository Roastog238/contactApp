// Services/ContactService.cs
using System.Collections.Generic;
using ContactManagementApp.Models;

namespace ContactManagementApp.Services
{
    public class ContactService
    {
        private List<Contact> contacts = new List<Contact>();
        private int nextId = 1;
        public ContactService()
        {
            contacts.Add(new Contact { Id = 0, FirstName = "John", LastName = "Doe", Email = "john@example.com", PhoneNumber = "1234567890" });
        }
        public List<Contact> GetContacts() => contacts;

        public Contact? GetContactById(int id) => contacts.FirstOrDefault(c => c.Id == id);

        public void AddContact(Contact contact)
        {
            contact.Id = nextId++;
            contacts.Add(contact);
        }

        public void UpdateContact(Contact updatedContact)
        {
            var contact = contacts.FirstOrDefault(c => c.Id == updatedContact.Id);
            if (contact != null)
            {
                contact.FirstName = updatedContact.FirstName;
                contact.LastName = updatedContact.LastName;
                contact.Email = updatedContact.Email;
                contact.PhoneNumber = updatedContact.PhoneNumber;
            }
        }

        public void DeleteContact(int id)
        {
            var contact = contacts.FirstOrDefault(c => c.Id == id);
            if (contact != null)
            {
                contacts.Remove(contact);

            }
        }
    }
}