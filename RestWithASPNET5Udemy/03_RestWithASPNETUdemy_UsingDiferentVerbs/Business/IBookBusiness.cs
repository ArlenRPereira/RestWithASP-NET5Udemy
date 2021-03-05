using _03_RestWithASPNETUdemy_UsingDiferentVerbs.Model;
using System.Collections.Generic;

namespace _03_RestWithASPNETUdemy_UsingDiferentVerbs.Business
{
    public interface IBookBusiness
    {
        Book Create(Book book);

        Book FindByID(long id);

        List<Book> FindAll();

        Book Update(Book book);

        void Delete(long id);
    }
}