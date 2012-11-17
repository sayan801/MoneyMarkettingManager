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

namespace sadlDemo.Clients
{
    /// <summary>
    /// Interaction logic for ViewCient.xaml
    /// </summary>
    public partial class ViewCient : Window
    {
       
        public ViewCient()
        {
            InitializeComponent();

            SearchClient searchClient = new SearchClient(SadlData.ViewOrEdit.View);
            this.AddChild(searchClient);
        }

      }
}
