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

namespace MmmDemo
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void employeesBtn_Click(object sender, RoutedEventArgs e)
        {
            controlsTab.SelectedIndex = 2;
        }

        

        private void agentsBtn_Click(object sender, RoutedEventArgs e)
        {
            controlsTab.SelectedIndex = 3;
        }

        private void clientsBtn_Click(object sender, RoutedEventArgs e)
        {
            controlsTab.SelectedIndex = 4;
        }

        private void closeEmpBtn_Click(object sender, RoutedEventArgs e)
        {
            controlsTab.SelectedIndex = 0;
        }

        private void dologinBtn_Click(object sender, RoutedEventArgs e)
        {
            LoginData loginData = new LoginData();
            loginData.userName = userNameTxtbox.Text;
            loginData.password = passwordBox.Password;
            loginData.type = (UserTypeEnum)Enum.Parse(typeof(UserTypeEnum), userTypeCombobox.Text, true);

            bool loginStatus = MmmDb.DbInteraction.DoMmmLogin(loginData);
            dologinBtn.IsEnabled = !loginStatus;
            dologoutBtn.IsEnabled = loginStatus;            
        }

        private void dologoutBtn_Click(object sender, RoutedEventArgs e)
        {
            dologinBtn.IsEnabled = true;
            dologoutBtn.IsEnabled = false;    
        }

        private void loginBtn_Click(object sender, RoutedEventArgs e)
        {
            controlsTab.SelectedIndex = 1;
        }

        private void addAgentsBtn_Click(object sender, RoutedEventArgs e)
        {
            AddNewAgent addAgent = new AddNewAgent();
            addAgent.ShowDialog();
        }

        private void viewAgentsBtn_Click(object sender, RoutedEventArgs e)
        {
            Agents.ViewAgent viewAgentWindow = new Agents.ViewAgent();
            viewAgentWindow.ShowDialog();
        }

        private void editAgentsBtn_Click(object sender, RoutedEventArgs e)
        {
            Agents.EditAgent editAgentWindow = new Agents.EditAgent();
            editAgentWindow.ShowDialog();
        }

        private void addClientsBtn_Click(object sender, RoutedEventArgs e)
        {
            Clients.AddNewClient addClient = new Clients.AddNewClient();
            addClient.ShowDialog();
        }

        private void addEmployeeBtn_Click(object sender, RoutedEventArgs e)
        {
            Employees.AddNewEmployee addEmployee = new Employees.AddNewEmployee();
            addEmployee.ShowDialog();
        }

        private void viewClientsBtn_Click(object sender, RoutedEventArgs e)
        {
            Clients.ViewCient viewClientWindow = new Clients.ViewCient();
            viewClientWindow.ShowDialog();
        }

        private void closeBtn_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void viewEmployeeBtn_Click(object sender, RoutedEventArgs e)
        {
            Employees.ViewEmployee viewEmp = new Employees.ViewEmployee();
            viewEmp.ShowDialog();
        }

        private void editEmployeeBtn_Click(object sender, RoutedEventArgs e)
        {
            Employees.EditEmployee editEmployee = new Employees.EditEmployee();
            editEmployee.ShowDialog();
        }

        private void controlsTab_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void editClientsBtn_Click(object sender, RoutedEventArgs e)
        {
            Clients.EditClient editClient = new Clients.EditClient();
            editClient.ShowDialog();
        }
    }
}
