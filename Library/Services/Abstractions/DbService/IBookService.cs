using Entity.Models;
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

        List<Book> Get(int count, int offset);

        Book Add(Book book);

        bool Remove(int id);

        Book Update(Book value);
    }
}
