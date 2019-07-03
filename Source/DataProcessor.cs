using ExamConsole.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace ExamConsole.Source
{
    class DataProcessor
    {
        private readonly IDataSource source;

        public DataProcessor(IDataSource s)
        {
            source = s;
        }

        public IEnumerable<Author> AllAuthors() {
            return source.GetAllAuthors();
        }

    }
}
