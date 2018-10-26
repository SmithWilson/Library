using Entity.Models;
using Library.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.Services.Abstractions.DbService
{
    /// <summary>
    /// Интерфейс для <see cref="Implementations.DbService.BookService"/>
    /// </summary>
    public interface IBookService
    {
        Book GetById(int id);

        BooksDTO Get(int offset, int count = 10);

        Book Add(Book book);

        bool Remove(int id);

        Book Update(Book value);
    }
}
