using Lab1_ASPNetConnectedMode.BLL;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using Lab1_ASPNetConnectedMode.DAL;

namespace Lab1_ASPNetConnectedMode.DAL
{
    public static class EmployeeDBNew
    {
        public static void SaveRecord(Employee employee)
        {
            //Connect DB
            SqlConnection conn = UtilityDB.ConnectDB();

            // perform insert operation
            //perform INSERT OPERATION

            SqlCommand cmdInsert = new SqlCommand();
            cmdInsert.Connection = conn;
            //cmdInsert.CommandText = "INSERT INTO Employee " +
            //                         "VALUES(" + employee.EmployeeNumber + "," +
            //                         "'" + employee.FirstName + "'," +
            //                         "'" + employee.LastName + "'," +
            //                         "'" + employee.JobTitle + "')";

            cmdInsert.CommandText = "INSERT INTO Employees(EmployeeNumber,FirstName,LastName,JobTitle) " +
                                    "VALUES (@EmployeeNumber,@FirstName,@LastName,@JobTitle)";
            cmdInsert.Parameters.AddWithValue("@EmployeeNumber", employee.EmployeeNumber);
            cmdInsert.Parameters.AddWithValue("@FirstName", employee.FirstName);
            cmdInsert.Parameters.AddWithValue("@LastName", employee.LastName);
            cmdInsert.Parameters.AddWithValue("@JobTitle", employee.JobTitle);
            cmdInsert.ExecuteNonQuery();
            // close db
            conn.Close();
            conn.Dispose();
        }

        public static List<Employee> GetAllRecords()
        {
            List<Employee> listS = new List<Employee>();
            SqlConnection conn = UtilityDB.ConnectDB();
            SqlCommand cmdSelectAll = new SqlCommand("SELECT * FROM Employees", conn);
            SqlDataReader reader = cmdSelectAll.ExecuteReader();
            while (reader.Read())
            {
                Employee emp = new Employee();
                emp.EmployeeNumber = Convert.ToInt32(reader["EmployeeNumber"]);
                emp.FirstName = reader["FirstName"].ToString();
                emp.LastName = reader["LastName"].ToString();
                emp.LastName = reader["JobTitle"].ToString();
                listS.Add(emp);
            }
            conn.Close();
            conn.Dispose();
            return listS;
        }

        public static Employee SearchRecordbyEmpNum(int EmpNum)
        {
            Employee emp = null;
            SqlConnection conn = UtilityDB.ConnectDB();
            SqlCommand cmdSearchByNumber = new SqlCommand();
            cmdSearchByNumber.Connection = conn;
            cmdSearchByNumber.CommandText = "SELECT * FROM Employees " +
                                          "WHERE EmployeeNumber=@EmployeeNumber";
            cmdSearchByNumber.Parameters.AddWithValue("@EmployeeNumber", EmpNum);
            SqlDataReader reader = cmdSearchByNumber.ExecuteReader();
            if (reader.Read())
            {
                emp = new Employee();
                emp.EmployeeNumber = Convert.ToInt32(reader["EmployeeNumber"]);
                emp.FirstName = reader["FirstName"].ToString();
                emp.LastName = reader["LastName"].ToString();
                emp.JobTitle = reader["JobTitle"].ToString();
            }
            conn.Close();
            conn.Dispose();
            return emp;
        }

        public static Employee SearchRecordbyName(string name)
        {
            Employee emp = null;
            SqlConnection conn = UtilityDB.ConnectDB();
            SqlCommand cmdSearchByNumber = new SqlCommand();
            cmdSearchByNumber.Connection = conn;
            cmdSearchByNumber.CommandText = "SELECT * FROM Employees " +
                                          "WHERE FirstName=@FirstName";
            cmdSearchByNumber.Parameters.AddWithValue("@FirstName", name);
            SqlDataReader reader = cmdSearchByNumber.ExecuteReader();
            if (reader.Read())
            {
                emp = new Employee();
                emp.EmployeeNumber = Convert.ToInt32(reader["EmployeeNumber"]);
                emp.FirstName = reader["FirstName"].ToString();
                emp.LastName = reader["LastName"].ToString();
                emp.JobTitle = reader["JobTitle"].ToString();
            }
            conn.Close();
            conn.Dispose();
            return emp;
        }
    }
}