using Microsoft.EntityFrameworkCore.Internal;
using _03_RestWithASPNETUdemy_UsingDiferentVerbs.Model;
using _03_RestWithASPNETUdemy_UsingDiferentVerbs.Model.Context;
using _03_RestWithASPNETUdemy_UsingDiferentVerbs.Repository;
using System.Collections.Generic;
using System;
using System.Threading;
using System.Linq;

namespace _03_RestWithASPNETUdemy_UsingDiferentVerbs.Business.Implementations
{
    public class PersonBusinessImplementation : IPersonBusiness
    {
       private readonly IPersonRepository _repository;

        public PersonBusinessImplementation(IPersonRepository repository)
        {
            _repository = repository;
        }

         public Person FindByID(long id)
        {
            return _repository.FindByID(id);
        }

        public List<Person> FindAll()
        {
            return _repository.FindAll();
        }

        public Person Create(Person person)
        {
            return _repository.Create(person);
        }

        public Person Update(Person person)
        {
            return _repository.Update(person);
        }

        public void Delete(long id)
        {
            _repository.Delete(id);
        }
    }
}