using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Rezerwacja_w_hotelu
{
    public class sql_connection
    {
        private static sql_connection instance;
        private sql_connection() {}
        public static sql_connection Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new sql_connection();
                }
                return instance;
            }
        }
        public static SqlConnection GetConnection()
        {
           
            String connStr = @"Data Source=(LocalDB)\v11.0;";
            connStr += @"AttachDBfilename=""|DataDirectory|\baza_danych.mdf"";";
            connStr += @"Integrated Security=True";
            SqlConnection connection = new SqlConnection(connStr);
            
            return connection;
        }
    }
}
