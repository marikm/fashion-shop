using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;


namespace fashionshop.Database
{
    public class Connection
    {
        private string connectionString;
        public Connection()
        {
            connectionString = 
               "Persist Security Info = false;" + // nao pedir senha para acessar o banco
               "server = localhost;" + //servidor do banco
               "database = shop;" + // nome do banco
               "uid = root;" +// usuario do banco 
               "pwd = ;";
        }

        public MySqlConnection getConnection()
        {
            try
            {
                MySqlConnection con = new MySqlConnection(connectionString);
                con.Open();
                return con;
            }
            catch (MySqlException ex)
            {
                throw new Exception("Error connection database, MysqlEx: " + ex.Message);
            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message);
            }
        }

        public void CloseConnection(MySqlConnection con)
        {
            try
            {
                if (con != null && con.State == System.Data.ConnectionState.Open)
                {
                    con.Close();
                    con.Dispose();
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error trying to close the connection to the database.", ex);
            }

        }
    }
}
