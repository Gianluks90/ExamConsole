using System;
using System.Collections.Generic;
using System.Text;

namespace ExamConsole.Models
{
    class Author
    {
        public int Id { get; set; }
        public string Firstname { get; set; }
        public string Lastname { get; set; }
        public DateTime Birthdate { get; set; }
        public string Email { get; set; }

        public Author()
        {

        }

        public Author(int id, string firstname, string lastname, DateTime birthdate, string email)
        {
            Id = id;
            Firstname = firstname;
            Lastname = lastname;
            Birthdate = birthdate;
            Email = email;
        }

        public override string ToString()
        {
            return $"Id: {Id}, Firstname: {Firstname}, Lastname: {Lastname}, " +
                $"Birthdate: {Birthdate.ToString("dd/MM/yyyy")}, Email: {Email}";
        }
    }
}
