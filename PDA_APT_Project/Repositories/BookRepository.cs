using PDA_APT_Project.Entities;
using System.Data.SqlClient;
using Dapper;


namespace PDA_APT_Project.Repositories
{
    public class BookRepository : BaseRepository
    {
        public BookRepository(SqlConnection connection) : base(connection)
        {
        }

        public List<Book> SelectAll()
        {
            return _connection.Query<Book>(@"select * from dbo.Books").AsList();
        }

        public void DeleteAll()
        {
            _connection.Query("DELETE FROM Books");
            _connection.Query("DBCC CHECKIDENT ('Books', RESEED, 0)");
        }

        public void Insert(Book book)
        {
            _connection.Query("INSERT INTO Books (BookName, Author, Price, PageNumber) VALUES (@BookName, @Author, @Price, @PageNumber)", book);
        }

        public void Delete(int id)
        {
            _connection.Query("DELETE FROM Books WHERE ID = @id", new { id});
        }


    }
}
