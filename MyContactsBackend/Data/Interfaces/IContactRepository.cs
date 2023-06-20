﻿using Data.Models;
using System.Collections.Generic;

namespace Data.Interfaces
{
    public interface IContactRepository
    {
        void CreateContact(Contact contact);

        List<Contact> GetContact();

        Contact GetById(int id);

        void UpdateContact(Contact contact);

        void DeleteContact(Contact contact);
    }
}
