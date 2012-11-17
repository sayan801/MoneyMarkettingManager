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

namespace MmmDemo.Clients
{
    /// <summary>
    /// Interaction logic for SearchClient.xaml
    /// </summary>
    public partial class SearchClient : UserControl
    {
        ObservableCollection<MmmData.ClientDetails> _clientCollection = new ObservableCollection<MmmData.ClientDetails>();


        public ObservableCollection<MmmData.ClientDetails> clientCollection
        {
            get
            {
                return _clientCollection;
            }
        }

        MmmData.ViewOrEdit type;

        public SearchClient(MmmData.ViewOrEdit typeDetails)
        {
            InitializeComponent();
            type = typeDetails;
        }

        private void viewAllClientsBtn_Click(object sender, RoutedEventArgs e)
        {
            _clientCollection.Clear();
            List<MmmData.ClientDetails> clients = MmmDb.DbInteraction.GetAllClientList();

            foreach (MmmData.ClientDetails clientInfo in clients)
                _clientCollection.Add(clientInfo);
        }

        private void clientListView_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            MmmData.ClientDetails selectedClient = GetSelectedItem();

            if (type == MmmData.ViewOrEdit.View)
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

        private MmmData.ClientDetails GetSelectedItem()
        {

            MmmData.ClientDetails agentToSelect = null;

            if (clientListView.SelectedIndex == -1)
                MessageBox.Show("Please Select an Item");
            else
            {
                MmmData.ClientDetails i = (MmmData.ClientDetails)clientListView.SelectedItem;

                agentToSelect = _clientCollection.Where(item => item.clientId.Equals(i.clientId)).First();
            }

            return agentToSelect;
        }
    
    }
}
