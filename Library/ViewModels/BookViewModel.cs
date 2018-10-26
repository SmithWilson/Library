using Entity.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI.WebControls;

namespace Library.ViewModels
{
    public class BookViewModel
    {
        public int Index { get; set; }

        public int Count { get; set; }

        public List<Book> Books { get; set; }

        public Repeater Repeater { get; set; }
    }
}