using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Lab1_ASPNetConnectedMode.DAL;
using System.Data.SqlClient;
using System.Windows.Forms;
using Lab1_ASPNetConnectedMode.BLL;
using Lab1_ASPNetConnectedMode.VALIDATION;



// Concept: PostBack evry time we click something it goes to the server and page_load is excecuted;


namespace Lab1_ASPNetConnectedMode.GUI
{
    public partial class WebFormEmployee : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                DropDownListEmployee.Items.Add("Employee Number");
                DropDownListEmployee.Items.Add("Firt Name");
                DropDownListEmployee.Items.Add("LastName");
            }

            //DropDownListEmployee.Items.Clear();
            //DropDownListEmployee.Items.Add("Employee Number");
            //DropDownListEmployee.Items.Add("Firt Name");
            //DropDownListEmployee.Items.Add("LastName");
        }

        protected void ButtonSave_Click(object sender, EventArgs e)
        {
            Employee employee = new Employee();
            employee.EmployeeNumber = Convert.ToInt32(TextBoxEMployeeNumber.Text.Trim());
            employee.FirstName = TextBoxName.Text.Trim();
            employee.LastName = TextBoxLastName.Text.Trim();
            employee.JobTitle = TextBoxJobTitle.Text.Trim();

            employee.SaveEmployee(employee);
        }

        protected void ButtonUpdate_Click(object sender, EventArgs e)
        {

        }

        protected void ButtonDelete_Click(object sender, EventArgs e)
        {

        }

        protected void ButtonListAll_Click(object sender, EventArgs e)
        {
            Employee emp = new Employee();
            GridViewEmployee.DataSource = emp.GetAllEmployees();
        }


        protected void ButtonSearch_Click(object sender, EventArgs e)
        {
            Employee emp = new Employee();
            if (!Validator.IsValidId(TextBoxEMployeeNumber.Text.Trim()))
            {
                MessageBox.Show("Employee Number must be 4 digits.", "Invalid Id");
                TextBoxEMployeeNumber.Text = string.Empty;
                TextBoxEMployeeNumber.Focus();
                return;
            }

        }



        //protected void Button1_Click(object sender, EventArgs e)
        //{
        //    Employee employee = new Employee();
        //    employee.EmployeeNumber = Convert.ToInt32(TextBoxEMployeeNumber.Text.Trim());
        //    employee.FirstName = TextBoxName.Text.Trim();
        //    employee.LastName = TextBoxLastName.Text.Trim();
        //    employee.JobTitle = TextBoxJobTitle.Text.Trim();

        //    employee.SaveEmployee(employee);
        //}



        //Employee employee = new Employee();


        //protected void Button1_Click(object sender, EventArgs e)
        //{
        //    SqlConnection connDB = UtilityDB.ConnectDB();
        //    MessageBox.Show(Convert.ToString(connDB.State), "Database Connection");
        //}
    }
}