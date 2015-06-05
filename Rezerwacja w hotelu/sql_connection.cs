using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Rezerwacja_w_hotelu
{
    public static class sql_connection
    {
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
