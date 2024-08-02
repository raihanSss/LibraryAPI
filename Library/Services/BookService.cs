using Library.Interfaces;
using Library.Models;
using System.Collections.Generic;
using System.Linq;
using Library.Models;

namespace Library.Services
{
    public class BookService : IBookService
    {
        private readonly List<Book> _books;

        public BookService()
        {
            _books = new List<Book>();
        }

        public string AddBook(Book book)
        {
            book.Id = _books.Any() ? _books.Max(b => b.Id) + 1 : 1;
            _books.Add(book);
            return "Buku berhasil di tambahkan";
        }

        public IEnumerable<Book> GetAllBook()
        {
            return _books;
        }

        public Book GetBookById(int id)
        {
            return _books.FirstOrDefault(b => b.Id == id);
        }

        public string UpdateBook(Book book)
        {
            var existingBook = _books.FirstOrDefault(b => b.Id == book.Id);
            if (existingBook != null)
            {
                existingBook.Title = book.Title;
                existingBook.Author = book.Author;
                existingBook.PublicationYear = book.PublicationYear;
                existingBook.ISBN = book.ISBN;
                return "Data buku berhasil diubah";
            }
            return "Buku tidak ditemukan";
        }

        public string DeleteBook(int id)
        {
            var book = _books.FirstOrDefault(b => b.Id == id);
            if (book != null)
            {
                _books.Remove(book);
                return "Data buku berhasil dihapus";
            }
            return "Buku tidak ditemukan";
        }
    }
}
