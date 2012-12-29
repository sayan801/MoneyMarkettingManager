using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using MmmData;

namespace MmmDemo.Employees
{
    /// <summary>
    /// Interaction logic for EmployeeInfo.xaml
    /// </summary>
    public partial class EmployeeInfo : UserControl
    {
        public EmployeeInfo()
        {
            InitializeComponent();
        }

        public EmployeeDetails getDetails()
        {

            EmployeeDetails employeeData = new EmployeeDetails();

            employeeData.employeeName = employeeNameTxtbox.Text;
            employeeData.employeeDob = employeeDobDatepicker.SelectedDate.Value;
            employeeData.employeeAddress = employeeAddressTxtbox.Text;
            employeeData.employeePhoneNumber = employeePhoneNumberTxtbox.Text;
            employeeData.employeeEmail = employeeEmailTxtbox.Text;
            employeeData.employeeJoinDate = employeeJoinDatePicker.SelectedDate.Value;
            employeeData.employeeDepartment = employeeDepartmentTxtbox.Text;
            employeeData.employeeSalary = Convert.ToDouble(employeeSalaryTxtbox.Text);
            employeeData.employeeManagerId = employeeManagerIdTxtbox.Text;
            return employeeData;
        }

        internal void SetDetails(EmployeeDetails employeeDetails)
        {
            employeeNameTxtbox.Text = employeeDetails.employeeName;
            employeeDobDatepicker.SelectedDate = employeeDetails.employeeDob;
            employeeAddressTxtbox.Text = employeeDetails.employeeAddress;
            employeePhoneNumberTxtbox.Text = employeeDetails.employeePhoneNumber;
            employeeEmailTxtbox.Text = employeeDetails.employeeEmail;
            employeeJoinDatePicker.SelectedDate = employeeDetails.employeeJoinDate;
            employeeDepartmentTxtbox.Text = employeeDetails.employeeDepartment;
            employeeSalaryTxtbox.Text = employeeDetails.employeeSalary.ToString();
            employeeManagerIdTxtbox.Text = employeeDetails.employeeManagerId;
            employeeIdTxtbox.Text = employeeDetails.employeeId;
        }
    }
}
