using Entity.Models;
using System.Data.Entity;

namespace Entity
{
    /// <summary>
    /// Контекст для работы с базой данных
    /// </summary>
    public class LibraryContext : DbContext
    {
        public LibraryContext() : base("LibratyConnection")
        {
        }

        /// <summary>
        /// Определение таблицы Book
        /// </summary>
        public DbSet<Book> Books { get; set; }
    }
}
