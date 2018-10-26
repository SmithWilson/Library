using Entity.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Library.DTO
{
    public class BooksDTO
    {
        public int Count { get; set; }

        public List<Book> Books { get; set; }
    }
}