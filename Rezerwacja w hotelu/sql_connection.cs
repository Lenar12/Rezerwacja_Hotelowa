using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Rezerwacja_w_hotelu
{
    public static class sql_connection
    {
        public static SqlConnection GetConnection()
        {
            String connStr = @"Data Source=(LocalDB)\v11.0;";
            connStr += @"AttachDBfilename=""D:\Programy\Rezerwacja w hotelu\Rezerwacja w hotelu\baza_danych.mdf"";";
            connStr += @"Integrated Security=True";
            SqlConnection connection = new SqlConnection(connStr);
            return connection;
        }
    }
}
