using System.Configuration;
using System.Data.SqlClient;


namespace DataAccessLayer
{
    public class DBConnection
    {
        static DBConnection _obj;

        string _connectionString = string.Empty;

        private DBConnection()
        {
            _connectionString = ConfigurationManager.ConnectionStrings["B22ASPDB"].ConnectionString;
        }

        public static DBConnection Instance
        {
            get
            {
                if (_obj == null)
                {
                    _obj = new DBConnection();
                }
                return _obj;
            }
        }
        public SqlConnection Connection
        {
            get
            {
                return new SqlConnection(_connectionString);
            }
        }

        public void OpenConnection()
        {
            Connection.Open();
        }
        public void CloseConnection()
        {
            Connection.Close();
        }
    }
}
