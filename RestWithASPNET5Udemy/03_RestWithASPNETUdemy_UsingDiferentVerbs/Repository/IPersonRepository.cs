using _03_RestWithASPNETUdemy_UsingDiferentVerbs.Model;
using System.Collections.Generic;

namespace _03_RestWithASPNETUdemy_UsingDiferentVerbs.Repository
{
    public interface IPersonRepository
    {
        Person Create(Person person);

        Person FindByID(long id);

        List<Person> FindAll();

        Person Update(Person person);

        void Delete(long id);

        bool Exists(long id);
    }
}