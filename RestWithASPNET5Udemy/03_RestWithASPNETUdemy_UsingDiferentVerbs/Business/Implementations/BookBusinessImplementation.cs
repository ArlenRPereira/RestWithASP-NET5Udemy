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
    public class BookBusinessImplementation : IBookBusiness
    {
       private readonly IRepository<Book> _repository;

        public BookBusinessImplementation(IRepository<Book> repository)
        {
            _repository = repository;
        }

         public Book FindByID(long id)
        {
            return _repository.FindByID(id);
        }

        public List<Book> FindAll()
        {
            return _repository.FindAll();
        }

        public Book Create(Book book)
        {
            return _repository.Create(book);
        }

        public Book Update(Book book)
        {
            return _repository.Update(book);
        }

        public void Delete(long id)
        {
            _repository.Delete(id);
        }
    }
}