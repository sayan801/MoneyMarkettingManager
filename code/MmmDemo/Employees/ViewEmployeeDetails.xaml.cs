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

namespace MmmDemo.Employees
{
    /// <summary>
    /// Interaction logic for ViewEmployeeDetails.xaml
    /// </summary>
    public partial class ViewEmployeeDetails : Window
    {
        public ViewEmployeeDetails(MmmData.EmployeeDetails employeeDetails)
        {
            InitializeComponent();
            employeeDetailsControl.SetDetails(employeeDetails);
        }

        private void closeBtn_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
