using System;
using System.Collections.Generic;
using System.Web;
using System.Web.Mvc;
using TestIocDi.Service;
using TestIocDi.ViewModel;

namespace TestIocDi.Controllers
{
    public class BookController: Controller
    {
        private readonly BookService _bookService;

        public BookController(BookService bookService)
        {
            _bookService = bookService;
        }

        public ActionResult Index()
        {
            var books = _bookService.GetAllBooks();
            ViewBag.BooksFromFile = TempData["BooksFromFile"] as List<BookViewModel>;
            if (TempData["Error"] != null)
            {
                ViewBag.ErrorMessage = TempData["Error"]; // Отображает сообщение об ошибке в представлении
            }
            return View(books);
        }

        [HttpPost]
        public ActionResult ParseFile(HttpPostedFileBase file)
        {
            string filePath = Server.MapPath("~/App_Data/" + file.FileName);
            file.SaveAs(filePath);
            try
            {
                List<BookViewModel> booksFromFiles = _bookService.GetBooksFromTextFile(filePath);
                TempData["BooksFromFile"] = booksFromFiles;
            }
            catch (Exception ex)
            {
                TempData["Error"] = "Ошибка при обработке файла";
            }
            return RedirectToAction("Index");
        }
    }
}
