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

namespace MmmDemo.Clients
{
    /// <summary>
    /// Interaction logic for EditClientDetails.xaml
    /// </summary>
    public partial class EditClientDetails : Window
    {
        public EditClientDetails(MmmData.ClientDetails selectedClient)
        {
            InitializeComponent();
            clientDetailsControl.SetDetails(selectedClient);
        }

        private void updateBtn_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
