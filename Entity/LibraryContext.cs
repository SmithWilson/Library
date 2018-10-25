using Entity.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
