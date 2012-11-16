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
using System.Windows.Shapes;

namespace sadlDemo.Employees
{
    /// <summary>
    /// Interaction logic for EditEmployeeDetails.xaml
    /// </summary>
    public partial class EditEmployeeDetails : Window
    {
        public EditEmployeeDetails(SadlData.EmployeeDetails employeeDetails)
        {
            InitializeComponent();
            employeeEditControl.SetDetails(employeeDetails);
        }

        private void updateBtn_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
