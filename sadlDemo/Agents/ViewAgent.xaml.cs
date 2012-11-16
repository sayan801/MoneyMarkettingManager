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
using System.Collections.ObjectModel;

namespace sadlDemo.Agents
{
    /// <summary>
    /// Interaction logic for ViewAgent.xaml
    /// </summary>
    public partial class ViewAgent : Window
    {
        //ObservableCollection<SadlData.AgentDetails> _agentCollection = new ObservableCollection<SadlData.AgentDetails>();


        //public ObservableCollection<SadlData.AgentDetails> agentCollection
        //{
        //    get
        //    {
        //        return _agentCollection;
        //    }
        //}

        public ViewAgent()
        {
            InitializeComponent();
            SearchAgent searchAgent = new SearchAgent(SadlData.ViewOrEdit.View);
            this.AddChild(searchAgent);
        }

        //private void viewAllAgentBtn_Click(object sender, RoutedEventArgs e)
        //{
        //    _agentCollection.Clear();
        //    List<SadlData.AgentDetails> agents = SadlDb.DbInteraction.GetAllAgentList();

        //    foreach (SadlData.AgentDetails agentInfo in agents)
        //        _agentCollection.Add(agentInfo);
        //}

        //private void agentListView_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        //{
        //    SadlData.AgentDetails selectedAgent = GetSelectedItem();
        //    ViewAgentDetails details = new ViewAgentDetails(selectedAgent);
        //    details.ShowDialog();
        //}

        //private SadlData.AgentDetails GetSelectedItem()
        //{

        //    SadlData.AgentDetails agentToSelect = null;

        //    if (agentListView.SelectedIndex == -1)
        //        MessageBox.Show("Please Select an Item");
        //    else
        //    {
        //        SadlData.AgentDetails i = (SadlData.AgentDetails)agentListView.SelectedItem;

        //        agentToSelect = _agentCollection.Where(item => item.agentId.Equals(i.agentId)).First();
        //    }

        //    return agentToSelect;
        //}
    }
}
