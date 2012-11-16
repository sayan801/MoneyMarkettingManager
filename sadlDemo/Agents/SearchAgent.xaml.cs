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

namespace sadlDemo.Agents
{
    /// <summary>
    /// Interaction logic for SearchAgent.xaml
    /// </summary>
    public partial class SearchAgent : UserControl
    {
        ObservableCollection<SadlData.AgentDetails> _agentCollection = new ObservableCollection<SadlData.AgentDetails>();


        public ObservableCollection<SadlData.AgentDetails> agentCollection
        {
            get
            {
                return _agentCollection;
            }
        }

        SadlData.ViewOrEdit type;

        public SearchAgent(SadlData.ViewOrEdit typeDetails)
        {
            InitializeComponent();
            type = typeDetails;
        }
        private void viewAllAgentBtn_Click(object sender, RoutedEventArgs e)
        {
            _agentCollection.Clear();
            List<SadlData.AgentDetails> agents = SadlDb.DbInteraction.GetAllAgentList();

            foreach (SadlData.AgentDetails agentInfo in agents)
                _agentCollection.Add(agentInfo);
        }

        private void agentListView_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            SadlData.AgentDetails selectedAgent = GetSelectedItem();

            if (type == SadlData.ViewOrEdit.View)
            {
                ViewAgentDetails details = new ViewAgentDetails(selectedAgent);
                details.ShowDialog();
            }
            else
            {
                EditAgentDetails editDetails = new EditAgentDetails(selectedAgent);
                editDetails.ShowDialog();
            }
           
        }

        private SadlData.AgentDetails GetSelectedItem()
        {

            SadlData.AgentDetails agentToSelect = null;

            if (agentListView.SelectedIndex == -1)
                MessageBox.Show("Please Select an Item");
            else
            {
                SadlData.AgentDetails i = (SadlData.AgentDetails)agentListView.SelectedItem;

                agentToSelect = _agentCollection.Where(item => item.agentId.Equals(i.agentId)).First();
            }

            return agentToSelect;
        }
    }
}
