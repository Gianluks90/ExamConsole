using ExamConsole.Source;
using System;

namespace ExamConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            DbDataSource source = new DbDataSource();
            DataProcessor processor = new DataProcessor(source);
            UserInterface UI = new UserInterface(processor);
            UI.MainMenu();
        } 
    }
}
