using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PDA_APT_Project.Repositories
{
    public abstract class BaseRepository
    {
        public const string DSN = @"Data Source=DESKTOP-UI4U0V1\SQLEXPRESS;Initial Catalog=DB_1;Integrated Security=True;Encrypt=False";
        public SqlConnection _connection;

        public BaseRepository(SqlConnection connection)
        {
            _connection = connection;
        }
    }
}
