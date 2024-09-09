using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.SqlClient;
using System.Configuration;

namespace Lab1_ASPNetConnectedMode.DAL
{
    public static class UtilityDB
    {
        //public static SqlConnection ConnectDB()
        //{
        //    SqlConnection conn = new SqlConnection();
        //    conn.ConnectionString = "server=ARIAM-THINKBOOK\\SQLExpress;database=EmployeeDBNew;user=sa;password=B@rcelon@2256*";
        //    conn.Open();
        //    return conn;
        //}

        public static SqlConnection ConnectDB()
        {
            SqlConnection conn = new SqlConnection();
            conn.ConnectionString = ConfigurationManager.ConnectionStrings["ConnectDB"].ConnectionString;
            conn.Open();
            return conn;
        }
    }
}