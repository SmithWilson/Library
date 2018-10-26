using Entity;
using Entity.Models;
using Library.Services.Abstractions.DbService;
using Library.Services.Implementations.DbService;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Library.WebForms
{
    public partial class Main : System.Web.UI.Page
    {
        public List<Book> Books;
        public void Page_Load(object sender, EventArgs e)
        {
            using (var context = new LibraryContext())
            {
                var bookService = new BookService(context);
                Books = bookService.GetAll();
            }

            bookRepeater.DataSource = Books;
            bookRepeater.DataBind();
        }
    }
}