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
using System.Collections.ObjectModel;

namespace sadlDemo.Employees
{
    /// <summary>
    /// Interaction logic for SearchEmployee.xaml
    /// </summary>
    public partial class SearchEmployee : UserControl
    {
        ObservableCollection<SadlData.EmployeeDetails> _employeeCollection = new ObservableCollection<SadlData.EmployeeDetails>();

        public ObservableCollection<SadlData.EmployeeDetails> employeeCollection
        {
            get
            {
                return _employeeCollection;
            }
        }

        SadlData.ViewOrEdit type;

        public SearchEmployee(SadlData.ViewOrEdit typeDetails)
        {
            InitializeComponent();
            type = typeDetails;
        }

        private void viewAllEmployeesBtn_Click(object sender, RoutedEventArgs e)
        {
            _employeeCollection.Clear();
            List<SadlData.EmployeeDetails> employees = SadlDb.DbInteraction.GetAllEmployeeList();

            foreach (SadlData.EmployeeDetails employeeInfo in employees)
                _employeeCollection.Add(employeeInfo);
        }

        private void employeeListView_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            SadlData.EmployeeDetails selectedemployee = GetSelectedItem();

            if (type == SadlData.ViewOrEdit.View)
            {
                ViewEmployeeDetails viewDetails = new ViewEmployeeDetails(selectedemployee);
                viewDetails.ShowDialog();
            }
            else
            {
                EditEmployeeDetails editDetails = new EditEmployeeDetails(selectedemployee);
                editDetails.ShowDialog();
            }
        }

        private SadlData.EmployeeDetails GetSelectedItem()
        {

            SadlData.EmployeeDetails agentToSelect = null;

            if (employeeListView.SelectedIndex == -1)
                MessageBox.Show("Please Select an Item");
            else
            {
                SadlData.EmployeeDetails i = (SadlData.EmployeeDetails)employeeListView.SelectedItem;

                agentToSelect = _employeeCollection.Where(item => item.employeeId.Equals(i.employeeId)).First();
            }

            return agentToSelect;
        }
    }
}
