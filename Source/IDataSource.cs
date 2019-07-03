using ExamConsole.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace ExamConsole.Source
{
    interface IDataSource
    {
        IEnumerable<Book> GetAllBooks();
        IEnumerable<Author> GetAllAuthors();
        void CreateBook();
    }
}
