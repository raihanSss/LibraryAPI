using Library.Models;
using System.Collections.Generic;

namespace Library.Interfaces
{
    public interface IBookService
    {
        string AddBook(Book book);
        IEnumerable<Book> GetAllBook();
        Book GetBookById(int id);
        string UpdateBook(Book book);
        string DeleteBook(int id);
    }
}
