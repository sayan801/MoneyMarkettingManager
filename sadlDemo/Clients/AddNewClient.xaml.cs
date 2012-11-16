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

namespace sadlDemo.Clients
{
    /// <summary>
    /// Interaction logic for AddNewClient.xaml
    /// </summary>
    public partial class AddNewClient : Window
    {
        public AddNewClient()
        {
            InitializeComponent();
        }

        private void registerNewClientBtn_Click(object sender, RoutedEventArgs e)
        {
            SadlData.ClientDetails clientDetails = clientInfoControl.GetDetails();

            clientDetails.clientId = SadlData.IdGenerator.GetClientUniqueId();

            if (SadlDb.DbInteraction.DoRegisterNewClient(clientDetails) == 1)
            {
                this.Close();
            }
            else
            {
                MessageBox.Show("Client registration failed... Try Again..");
            }
        }

      
    }
}
