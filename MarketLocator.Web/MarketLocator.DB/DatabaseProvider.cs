using MarketLocator.Interfaces.Database;
using System;
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

        public SqlDataReader ReadCommand(string commandString, string gender, int minimumAge, int maximumAge, DateTime date)
        {
            this.Connection.ConnectionString = ConnectionString;

            this.Command.CommandText = commandString;
            this.Command.CommandType = CommandType.StoredProcedure;

            if (gender != null)
            {
                this.Command.Parameters.Add("@gender", SqlDbType.VarChar).Value = gender;
            }

            if (minimumAge != 0)
            {
                this.Command.Parameters.Add("@minimumAge", SqlDbType.Int).Value = minimumAge;
            }

            if (maximumAge != 0)
            {
                this.Command.Parameters.Add("@maximumAge", SqlDbType.Int).Value = maximumAge;
            }

            if (date != null)
            {
                this.Command.Parameters.Add("@date", SqlDbType.Date).Value = date.Date;
            }

            this.Command.Connection = this.Connection;

            this.Connection.Open();

            SqlDataReader reader = this.Command.ExecuteReader();

            return reader;
        }
    }
}