using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace assistant
{
    class DatabaseMNG
    {
        //поле данных соединения
        MySqlConnection connection = new MySqlConnection("server=localhost;" + "port=3306;" + 
            "username=root" + "password=;" + "database=rzdh.database");
        
        //open connection
        public void OpenConnection()
        {
            if(connection.State == System.Data.ConnectionState.Closed)
            {
                connection.Open();
            }
        }

        //close connection
        public void CloseConnection()
        {
            if (connection.State == System.Data.ConnectionState.Open)
            {
                connection.Close();
            }
        }

        //input 
        public MySqlConnection GetConnection 
        { 
            get 
            { 
                return connection; 
            } 
        }
    }
}
