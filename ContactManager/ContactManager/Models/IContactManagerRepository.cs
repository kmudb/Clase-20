﻿using System.Collections.Generic;

namespace ContactManager.Models
{
    public interface IContactManagerRepository
    {
        Contact CreateContact(Contact contactToCreate);
        void DeleteContact(Contact contactToDelete);
        Contact EditContact(Contact contactToEdit);
        Contact GetContact(int id);
        IEnumerable<Contact> ListContacts();

    }
}
