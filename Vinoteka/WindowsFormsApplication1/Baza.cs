using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;

namespace WindowsFormsApplication1
{
    class Baza
    {
        private static Baza instance;
        private string connectionString;
        private SqlConnection connection;

        public static Baza Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new Baza();
                }
                return instance;
            }
        }

        public string ConnectionString
        {
            get { return connectionString; }
            private set { connectionString = value; }
        }
        public SqlConnection Connection
        {
            get { return connection; }
            private set { connection = value; }
        }

        private Baza()
        {
            ConnectionString = @"Data Source=.\SQLEXPRESS;AttachDbFilename=|DataDirectory|\Vinoteka.mdf;Integrated Security=True;User Instance=True";
            Connection = new SqlConnection(ConnectionString);
            Connection.Open();
        }

        ~Baza()
        {
            //Connection.Close();
            Connection = null;
        }

        public SqlDataReader DohvatiDataReader(string sqlUpit)
        {
            SqlCommand command = new SqlCommand(sqlUpit, Connection);
            return command.ExecuteReader();
        }

        public object DohvatiVrijednost(string sqlUpit)
        {
            SqlCommand command = new SqlCommand(sqlUpit, Connection);
            return command.ExecuteScalar();
        }

        public int IzvrsiUpit(string sqlUpit)
        {

            SqlCommand command = new SqlCommand(sqlUpit, Connection);
            return command.ExecuteNonQuery();
        }
    }
}
