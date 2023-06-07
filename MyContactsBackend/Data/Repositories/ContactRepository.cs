using Data.Interfaces;
using System.Collections.Generic;

namespace Data.Repositories
{
    public class ContactRepository : IContactRepository
    {
        public void CreateContact()
        {
            
        }

        public void DeleteContact()
        {
            
        }

        public List<string> GetContact()
        {
            return new List<string>() { "tio joão", "tia maria", "vô paulo" };
        }

        public void UpdateContact()
        {
            
        }
    }
}
