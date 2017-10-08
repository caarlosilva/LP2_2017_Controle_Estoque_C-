using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Data;

namespace ControlX
{
    class Database 
    {

        private static MySqlConnection connection;
        private static Database instance;
        private const string URL = "Server=127.0.0.1; Database=controlx; Uid=root; Pwd=;";
        private Database()
        {
            connection = new MySqlConnection(URL);
        }
        public static Database GetInstance()
        {
            if (instance == null)
                instance = new Database();
            return instance;
        }
        public MySqlConnection GetConnection()
        {
            return connection;
        }
        public void ExecuteNonQuery(string qry)
        {
            if (connection.State != System.Data.ConnectionState.Open)
                connection.Open();
            MySqlCommand comm = new MySqlCommand(qry, connection);
            comm.ExecuteNonQuery();
            connection.Close();
        }
        public DataSet ExecuteQuery(string qry)
        {
            if (connection.State != ConnectionState.Open)
                connection.Open();
            MySqlCommand comm = new MySqlCommand(qry, connection);
            MySqlDataAdapter da = new MySqlDataAdapter(comm);
            DataSet ds = new DataSet();
            ds.Clear();
            da.Fill(ds);
            connection.Close();
            return ds;
        }
    }

}

