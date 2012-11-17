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

namespace MmmDemo.Employees
{
    /// <summary>
    /// Interaction logic for SearchEmployee.xaml
    /// </summary>
    public partial class SearchEmployee : UserControl
    {
        ObservableCollection<MmmData.EmployeeDetails> _employeeCollection = new ObservableCollection<MmmData.EmployeeDetails>();

        public ObservableCollection<MmmData.EmployeeDetails> employeeCollection
        {
            get
            {
                return _employeeCollection;
            }
        }

        MmmData.ViewOrEdit type;

        public SearchEmployee(MmmData.ViewOrEdit typeDetails)
        {
            InitializeComponent();
            type = typeDetails;
        }

        private void viewAllEmployeesBtn_Click(object sender, RoutedEventArgs e)
        {
            _employeeCollection.Clear();
            List<MmmData.EmployeeDetails> employees = MmmDb.DbInteraction.GetAllEmployeeList();

            foreach (MmmData.EmployeeDetails employeeInfo in employees)
                _employeeCollection.Add(employeeInfo);
        }

        private void employeeListView_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            MmmData.EmployeeDetails selectedemployee = GetSelectedItem();

            if (type == MmmData.ViewOrEdit.View)
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

        private MmmData.EmployeeDetails GetSelectedItem()
        {

            MmmData.EmployeeDetails agentToSelect = null;

            if (employeeListView.SelectedIndex == -1)
                MessageBox.Show("Please Select an Item");
            else
            {
                MmmData.EmployeeDetails i = (MmmData.EmployeeDetails)employeeListView.SelectedItem;

                agentToSelect = _employeeCollection.Where(item => item.employeeId.Equals(i.employeeId)).First();
            }

            return agentToSelect;
        }
    }
}
