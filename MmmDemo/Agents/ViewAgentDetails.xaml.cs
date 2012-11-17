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
    /// Interaction logic for ViewAgentDetails.xaml
    /// </summary>
    public partial class ViewAgentDetails : Window
    {
        public ViewAgentDetails(SadlData.AgentDetails agentDetails)
        {
            InitializeComponent();

            agentDetailsControl.SetDetails(agentDetails);
        }

        private void closeBtn_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
