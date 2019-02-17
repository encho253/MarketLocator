using MarketLocator.Interfaces.Database;
using System.Data;
using System.Data.SqlClient;

namespace MarketLocator.DB
{
    public class DatabaseProvider : IDatabaseProvider
    {
        private const string ConnectionString = "Data Source=.;Initial Catalog=SMART_CITIES;Integrated Security=True";

        public DatabaseProvider()
        {
            this.Connection = new SqlConnection();
            this.Command = new SqlCommand();
        }

        public SqlConnection Connection { get; set; }

        public SqlCommand Command { get; set; }

        public SqlDataReader ReadCommand(string commandString, string commandParameter)
        {
            this.Connection.ConnectionString = ConnectionString;

            this.Command.CommandText = commandString;
            this.Command.CommandType = CommandType.StoredProcedure;

            if (commandParameter != null)
            {
                this.Command.Parameters.Add("@table", SqlDbType.VarChar).Value = commandParameter;
            }

            this.Command.Connection = this.Connection;

            this.Connection.Open();

            SqlDataReader reader = this.Command.ExecuteReader();

            this.Connection.Close();

            return reader;
        }
    }
}