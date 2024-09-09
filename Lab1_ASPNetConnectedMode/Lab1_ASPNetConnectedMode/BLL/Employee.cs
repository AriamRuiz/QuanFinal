using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Lab1_ASPNetConnectedMode.DAL;

namespace Lab1_ASPNetConnectedMode.BLL
{
    public class Employee
    {
        //private class variables
        private int employeeNumber;
        private string firstName;
        private string lastName;
        private string jobTitle;
        //properties
       
        public string FirstName { get => firstName; set => firstName = value; }
        public string LastName { get => lastName; set => lastName = value; }
        public string JobTitle { get => jobTitle; set => jobTitle = value; }
        public int EmployeeNumber { get => employeeNumber; set => employeeNumber = value; }
        //custom methods

        public void SaveEmployee(Employee employee) => EmployeeDBNew.SaveRecord(employee);

        public List<Employee> GetAllEmployees() => EmployeeDBNew.GetAllRecords();

        public static Employee SearchEmployee(int id)
        {
            return EmployeeDBNew.SearchRecordbyEmpNum(id);
        }
    }
}