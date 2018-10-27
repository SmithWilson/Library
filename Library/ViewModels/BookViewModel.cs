using Entity.Models;
using System.Collections.Generic;

namespace Library.ViewModels
{
    public class BookViewModel
    {
        public int Index { get; set; }

        public int Count { get; set; }

        public List<Book> Books { get; set; }
    }
}