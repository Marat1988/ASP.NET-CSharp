using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using TestIocDi.Context;
using TestIocDi.Models;
using TestIocDi.ViewModel;

namespace TestIocDi.Repository
{
    public class BookRepository : IDisposable, IBookRepository
    {
        private readonly TestContext db = new TestContext();

        public List<Book> GetAllBooks() => db.Books.ToList();

        public List<BookViewModel> GetBooksFromTextFile(string FilePath)
        {
            string[] lines = File.ReadAllLines(FilePath);
            var books = lines.Where(line => line.Replace(" ", "").Trim() != "")
                .Select(line =>
                {
                    string[] lineData = line.Split(' ');
                    return new BookViewModel(lineData[0].Trim(), lineData[1].Trim(), lineData[2].Trim(), Convert.ToInt32(lineData[3].Trim()), lineData[4].Trim());
                }).ToList();
            return books;
        }

        public void Dispose() => db?.Dispose();
    }
}