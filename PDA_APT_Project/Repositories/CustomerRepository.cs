using Dapper;
using PDA_APT_Project.Entities;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PDA_APT_Project.Repositories
{
    public class CustomerRepository : BaseRepository
    {
        public CustomerRepository(SqlConnection connection) : base(connection)
        {
        }

        public List<Customer> SelectAll()
        {
            return _connection.Query<Customer>(@"select * from dbo.Customers").AsList();
        }
    }
}
