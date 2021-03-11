using _03_RestWithASPNETUdemy_UsingDiferentVerbs.Model;
using _03_RestWithASPNETUdemy_UsingDiferentVerbs.Repository;
using _03_RestWithASPNETUdemy_UsingDiferentVerbs.Data.VO;
using _03_RestWithASPNETUdemy_UsingDiferentVerbs.Data.Converter;
using _03_RestWithASPNETUdemy_UsingDiferentVerbs.Data.Converter.Implementations;
using System.Collections.Generic;

namespace _03_RestWithASPNETUdemy_UsingDiferentVerbs.Business.Implementations
{
    public class PersonBusinessImplementation : IPersonBusiness
    {
       private readonly IRepository<Person> _repository;
       private readonly PersonConverter _converter;

        public PersonBusinessImplementation(IRepository<Person> repository)
        {
            _repository = repository;
            _converter = new PersonConverter();
        }

         public PersonVO FindByID(long id)
        {
            return _converter.Parse(_repository.FindByID(id));
        }

        public List<PersonVO> FindAll()
        {
            return _converter.Parse(_repository.FindAll());
        }

        public PersonVO Create(PersonVO person)
        {
            var personEntity = _converter.Parse(person);
            personEntity = _repository.Create(personEntity);
            return _converter.Parse(personEntity);
        }

        public PersonVO Update(PersonVO person)
        {
            var personEntity = _converter.Parse(person);
            personEntity = _repository.Update(personEntity);
            return _converter.Parse(personEntity);
        }

        public void Delete(long id)
        {
            _repository.Delete(id);
        }
    }
}