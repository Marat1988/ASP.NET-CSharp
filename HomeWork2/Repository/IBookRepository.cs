using System.Collections.Generic;
using TestIocDi.Models;
using TestIocDi.ViewModel;

namespace TestIocDi.Repository
{
    public interface IBookRepository
    {
        List<Book> GetAllBooks();
        List<BookViewModel> GetBooksFromTextFile(string FilePath);
    }
}
