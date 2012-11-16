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

namespace sadlDemo.Agents
{
    /// <summary>
    /// Interaction logic for EditAgentDetails.xaml
    /// </summary>
    public partial class EditAgentDetails : Window
    {
        public EditAgentDetails(SadlData.AgentDetails agentDetails)
        {
            InitializeComponent();

            agentDetailsControl.SetDetails(agentDetails);
        
        }

        private void updateBtn_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
