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

namespace MmmDemo.Agents
{
    /// <summary>
    /// Interaction logic for EditAgent.xaml
    /// </summary>
    public partial class EditAgent : Window
    {
        public EditAgent()
        {
            InitializeComponent();
            SearchAgent searchAgent = new SearchAgent(MmmData.ViewOrEdit.Edit);
            this.AddChild(searchAgent);
        }
    }
}
