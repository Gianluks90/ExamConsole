using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Text;
using ExamConsole.Models;

namespace ExamConsole.Source
{
    class DbDataSource : IDataSource
    {

        const string CONNECTION = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=ADOdb;Integrated Security=True";
        const string QUERY_ALL_BOOKS = "SELECT * FROM Book";
        const string QUERY_ALL_AUTHORS = "SELECT * FROM Author";


        public void CreateBook()
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Author> GetAllAuthors()
        {
            using (SqlConnection conn = new SqlConnection(CONNECTION))
            {
                conn.Open();
                using(SqlCommand cmd = new SqlCommand(QUERY_ALL_AUTHORS, conn))
                {
                    SqlDataReader reader = cmd.ExecuteReader();
                    var posId = reader.GetOrdinal("Id");
                    var posFirstname = reader.GetOrdinal("Firstname");
                    var posLastname = reader.GetOrdinal("Lastname");
                    var posBirthdate = reader.GetOrdinal("Birthdate");
                    var posEmail = reader.GetOrdinal("Email");

                    var authors = new List<Author>();

                    while (reader.Read())
                    {
                        var author = new Author(
                            reader.GetInt32(posId),
                            reader.GetString(posFirstname),
                            reader.GetString(posLastname),
                            reader.GetDateTime(posBirthdate),
                            reader.GetString(posEmail)
                            );
                        authors.Add(author);
                    }
                    return authors;
                }
            }
        }

        public IEnumerable<Book> GetAllBooks()
        {
            throw new NotImplementedException();
        }
    }
}
