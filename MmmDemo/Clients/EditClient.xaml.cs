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
    /// Interaction logic for EditClient.xaml
    /// </summary>
    public partial class EditClient : Window
    {
        public EditClient()
        {
            InitializeComponent();
            SearchClient searchClient = new SearchClient(SadlData.ViewOrEdit.Edit);
            this.AddChild(searchClient);
        }
    }
}
