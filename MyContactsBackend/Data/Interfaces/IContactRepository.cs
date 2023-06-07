using System.Collections.Generic;

namespace Data.Interfaces
{
    public interface IContactRepository
    {
        void CreateContact();

        List<string> GetContact();

        void UpdateContact();

        void DeleteContact();
    }
}
