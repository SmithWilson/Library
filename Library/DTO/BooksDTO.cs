using Entity.Models;
using System.Collections.Generic;

namespace Library.DTO
{
    public class BooksDTO
    {
        /// <summary>
        /// Количество книг
        /// </summary>
        public int Count { get; set; }

        /// <summary>
        /// Книги
        /// </summary>
        public List<Book> Books { get; set; }
    }
}