using ExamConsole.Models;
using ExamConsole.Source;
using System;
using System.Collections.Generic;
using System.Text;

namespace ExamConsole
{
    class UserInterface
    {

        const string MENU = "Inserisci:\n'L' lista libri\n'A' lista autori\n" +
            "'I' per inserire libro\n'M' per media dei prezzi\n'D' per la moda dei prezzi\n'E' per uscire\n";

        DataProcessor processor;

        public UserInterface(DataProcessor p)
        {
            processor = p;
        }

        public void MainMenu()
        {
            Console.WriteLine(MENU);
            var input = Console.ReadLine().ToLower();

            switch (input[0])
            {
                //case 'l':
                //    GetAllBooks();
                //    break;
                case 'a':
                    GetAllAuthors();
                    break;
                //case 'i':
                //    CreateBook();
                //    break;
                //case 'm':
                //    GetAverage();
                //    break;
                //case 'd':
                //    GetMode();
                //    break;
                case 'e':
                    return;
            }
            MainMenu();
        }

        private void GetAllAuthors()
        {
            IEnumerable<Author> authors = processor.AllAuthors();

            foreach (var a in authors)
            {
                Console.WriteLine(a);
            }
        }
    }
}
