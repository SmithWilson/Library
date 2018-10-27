using AutoMapper;
using Entity.Models;
using Library.Services.Abstractions.DbService;
using Library.ViewModels;
using System.Web.Mvc;

namespace Library.Controllers
{
    public class BookController : Controller
    {
        private readonly IBookService _bookService;

        public BookController(IBookService bookService)
        {
            _bookService = bookService;
        }

        [HttpGet]
        public ActionResult Index(int index = 0)
        {
            var booksDTO = _bookService.Get(index);

            var bookVM = new BookViewModel
            {
                Index = index,
                Books = booksDTO.Books,
                Count = booksDTO.Count
            };

            return View(bookVM);
        }

        [HttpGet]
        public ActionResult Add()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Add(AddBookViewModel viewModel)
        {
            if (ModelState.IsValid)
            {
                var book = Mapper.Map<Book>(viewModel);
                _bookService.Add(book);

                return RedirectToAction("Index", "Book");
            }
            else
            {
                ModelState.AddModelError("", "Неверные данные");
            }

            return View(viewModel);
        }

        [HttpGet]
        public JsonResult Remove(int bookId)
        {
            var result = _bookService.Remove(bookId);

            return Json(result, JsonRequestBehavior.AllowGet);
        }

        [HttpGet]
        public ActionResult Update(int bookId)
        {
            var book = _bookService.GetById(bookId);
            return View(book);
        }

        [HttpPost]
        public ActionResult Update(Book book)
        {
            if (ModelState.IsValid)
            {
                _bookService.Update(book);
                return RedirectToAction("Index", "Book");
            }
            else
            {
                ModelState.AddModelError("", "Неверные данные");
            }

            return View(book);
        }
    }
}