using Entity.Models;
using Library.DTO;
using System.Collections.Generic;

namespace Library.Services.Abstractions.DbService
{
    /// <summary>
    /// Интерфейс для <see cref="Implementations.DbService.BookService"/>
    /// </summary>
    public interface IBookService
    {
        Book GetById(int id);

        BooksDTO Get(int offset, int count = 10);

        List<Book> GetAll();

        Book Add(Book book);

        bool Remove(int id);

        Book Update(Book value);
    }
}
