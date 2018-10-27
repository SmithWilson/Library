using Entity;
using Entity.Models;
using Library.Services.Implementations.DbService;
using System;
using System.Collections.Generic;

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