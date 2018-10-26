using Entity;
using Entity.Models;
using Library.DTO;
using Library.Services.Abstractions.DbService;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Library.Services.Implementations.DbService
{
    /// <summary>
    /// Реализация интерфейса <see cref="Abstractions.DbService.IBookService"/>
    /// Для работы с таблицей Book
    /// </summary>
    public class BookService : IBookService
    {
        private readonly LibraryContext _context;

        /// <summary>
        /// Получение зависимостей через конструктор
        /// </summary>
        /// <param name="context">Контекст базы данных</param>
        public BookService(LibraryContext context)
        {
            _context = context;
        }

        public Book Add(Book value)
        {
            if (value == null)
            {
                throw new ArgumentNullException(nameof(value));
            }

            var book = _context.Books.Add(value);
            _context.SaveChanges();

            return book;
        }

        public BooksDTO Get(int offset, int count = 10)
        {
            var books = _context.Books
                .OrderBy(b => b.Id)
                .Skip(offset * 10)
                .Take(count)
                .ToList();

            var booksCount = _context.Books
                .Count();

            var dto = new BooksDTO
            {
                Books = books,
                Count = booksCount
            };

            return dto;
        }

        public Book GetById(int id)
            => _context.Books.FirstOrDefault(b => b.Id == id);

        public bool Remove(int id)
        {
            var book = _context.Books.FirstOrDefault(b => b.Id == id);
            if (book != null)
            {
                try
                {
                    _context.Books.Remove(book);
                    _context.SaveChanges();
                }
                catch (Exception)
                {
                    return false;
                }
            }

            return true;
        }

        public Book Update(Book value)
        {
            try
            {
                var book = _context.Books.FirstOrDefault(b => b.Id == value.Id);
                if (book != null)
                {
                    var properties = value.GetType().GetProperties().Skip(1);
                    foreach (var property in properties)
                    {
                        property.SetValue(book, property.GetValue(value));
                    }

                    _context.SaveChanges();
                }

                return book;
            }
            catch (Exception ex)
            {
                throw new InvalidCastException("Failed to update.", ex);
            }
        }
    }
}