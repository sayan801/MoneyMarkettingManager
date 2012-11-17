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

namespace MmmDemo.Agents
{
    /// <summary>
    /// Interaction logic for ViewAgent.xaml
    /// </summary>
    public partial class ViewAgent : Window
    {
        //ObservableCollection<MmmData.AgentDetails> _agentCollection = new ObservableCollection<MmmData.AgentDetails>();


        //public ObservableCollection<MmmData.AgentDetails> agentCollection
        //{
        //    get
        //    {
        //        return _agentCollection;
        //    }
        //}

        public ViewAgent()
        {
            InitializeComponent();
            SearchAgent searchAgent = new SearchAgent(MmmData.ViewOrEdit.View);
            this.AddChild(searchAgent);
        }

        //private void viewAllAgentBtn_Click(object sender, RoutedEventArgs e)
        //{
        //    _agentCollection.Clear();
        //    List<MmmData.AgentDetails> agents = MmmDb.DbInteraction.GetAllAgentList();

        //    foreach (MmmData.AgentDetails agentInfo in agents)
        //        _agentCollection.Add(agentInfo);
        //}

        //private void agentListView_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        //{
        //    MmmData.AgentDetails selectedAgent = GetSelectedItem();
        //    ViewAgentDetails details = new ViewAgentDetails(selectedAgent);
        //    details.ShowDialog();
        //}

        //private MmmData.AgentDetails GetSelectedItem()
        //{

        //    MmmData.AgentDetails agentToSelect = null;

        //    if (agentListView.SelectedIndex == -1)
        //        MessageBox.Show("Please Select an Item");
        //    else
        //    {
        //        MmmData.AgentDetails i = (MmmData.AgentDetails)agentListView.SelectedItem;

        //        agentToSelect = _agentCollection.Where(item => item.agentId.Equals(i.agentId)).First();
        //    }

        //    return agentToSelect;
        //}
    }
}
