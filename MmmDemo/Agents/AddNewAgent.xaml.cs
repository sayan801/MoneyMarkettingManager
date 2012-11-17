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

namespace sadlDemo
{
    /// <summary>
    /// Interaction logic for AgentInfo.xaml
    /// </summary>
    public partial class AddNewAgent : Window
    {
        public AddNewAgent()
        {
            InitializeComponent();
        }

        private void registerNewAgentBtn_Click(object sender, RoutedEventArgs e)
        {
            SadlData.AgentDetails agentDetails = agentInfoControl.GetDetails();
            
            agentDetails.agentId = SadlData.IdGenerator.GetAgentUniqueId();

            if (SadlDb.DbInteraction.DoRegisterNewAgent(agentDetails) == 1)
            {
                this.Close();
            }
            else
            {
                MessageBox.Show("Agent registration failed... Try Again..");
            }

        }
    }
}
