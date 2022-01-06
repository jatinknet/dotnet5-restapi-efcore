using BookStore.Data.Models;
using BookStore.Data.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;

namespace BookStore.Data.Services
{
    public class BooksService
    {
        private AppDBContext _context;
        public BooksService(AppDBContext context)
        {
            _context = context;
        }

        public void AddBook(BookVM book)
        {

            var _book = new Book()
            {
                Name = book.Name,
                Description = book.Description,
                IsRead = book.IsRead,
                DateRead = book.DateRead,
                Genre = book.Genre,
                Author = book.Author,
                Rate = book.Rate,
                CoverUrl = book.CoverUrl,
                DateAdded = DateTime.Now

            };

            _context.Books.Add(_book);
            _context.SaveChanges();

        }

        public List<Book> GetAllBooks() => _context.Books.ToList();
        public Book GetBookById(int bookId) => _context.Books.FirstOrDefault(x => x.Id == bookId);


        public Book UpdateBookById(int bookId, BookVM book)
        {
            var _book = _context.Books.FirstOrDefault(n => n.Id == bookId);
            if (_book != null)
            {
                _book.Name = book.Name;
                _book.Description = book.Description;
                _book.IsRead = book.IsRead;
                _book.DateRead = book.IsRead ? book.DateRead.Value : null;
                _book.Rate = book.IsRead ? book.Rate.Value : null;
                _book.Genre = book.Genre;
                _book.CoverUrl = book.CoverUrl;

                _context.SaveChanges();
            }

            return _book;
        }

        public void DeleteBookById(int bookId)
        {
            var _book = _context.Books.FirstOrDefault(n => n.Id == bookId);
            if (_book != null)
            {
                _context.Books.Remove(_book);
                _context.SaveChanges();
            }
        }

    }
}
