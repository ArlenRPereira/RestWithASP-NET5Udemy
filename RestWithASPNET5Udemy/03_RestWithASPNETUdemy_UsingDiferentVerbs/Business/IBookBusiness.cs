using _03_RestWithASPNETUdemy_UsingDiferentVerbs.Data.VO;
using System.Collections.Generic;

namespace _03_RestWithASPNETUdemy_UsingDiferentVerbs.Business
{
    public interface IBookBusiness
    {
        BookVO Create(BookVO book);

        BookVO FindByID(long id);

        List<BookVO> FindAll();

        BookVO Update(BookVO book);

        void Delete(long id);
    }
}