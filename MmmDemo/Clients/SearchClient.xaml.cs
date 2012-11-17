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

namespace sadlDemo.Clients
{
    /// <summary>
    /// Interaction logic for SearchClient.xaml
    /// </summary>
    public partial class SearchClient : UserControl
    {
        ObservableCollection<SadlData.ClientDetails> _clientCollection = new ObservableCollection<SadlData.ClientDetails>();


        public ObservableCollection<SadlData.ClientDetails> clientCollection
        {
            get
            {
                return _clientCollection;
            }
        }

        SadlData.ViewOrEdit type;

        public SearchClient(SadlData.ViewOrEdit typeDetails)
        {
            InitializeComponent();
            type = typeDetails;
        }

        private void viewAllClientsBtn_Click(object sender, RoutedEventArgs e)
        {
            _clientCollection.Clear();
            List<SadlData.ClientDetails> clients = SadlDb.DbInteraction.GetAllClientList();

            foreach (SadlData.ClientDetails clientInfo in clients)
                _clientCollection.Add(clientInfo);
        }

        private void clientListView_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            SadlData.ClientDetails selectedClient = GetSelectedItem();

            if (type == SadlData.ViewOrEdit.View)
            {
                ViewClientDetails details = new ViewClientDetails(selectedClient);
                details.ShowDialog();
            }
            else
            {
                EditClientDetails editDetails = new EditClientDetails(selectedClient);
                editDetails.ShowDialog();
            }
        }

        private SadlData.ClientDetails GetSelectedItem()
        {

            SadlData.ClientDetails agentToSelect = null;

            if (clientListView.SelectedIndex == -1)
                MessageBox.Show("Please Select an Item");
            else
            {
                SadlData.ClientDetails i = (SadlData.ClientDetails)clientListView.SelectedItem;

                agentToSelect = _clientCollection.Where(item => item.clientId.Equals(i.clientId)).First();
            }

            return agentToSelect;
        }
    
    }
}
