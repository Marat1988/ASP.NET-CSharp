using System.Collections.Generic;
using TestIocDi.Models;
using TestIocDi.Repository;
using TestIocDi.ViewModel;

namespace TestIocDi.Service
{
    public class BookService
    {
        private readonly IBookRepository _bookRepository;

        public BookService(IBookRepository bookRepository) => _bookRepository = bookRepository;

        public List<Book> GetAllBooks() => _bookRepository.GetAllBooks();

        public List<BookViewModel> GetBooksFromTextFile(string FilePath) => _bookRepository.GetBooksFromTextFile(FilePath);
    }
}