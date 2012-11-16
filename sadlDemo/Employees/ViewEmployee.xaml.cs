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

namespace sadlDemo.Employees
{
    /// <summary>
    /// Interaction logic for ViewEmployee.xaml
    /// </summary>
    public partial class ViewEmployee : Window
    {

       

        public ViewEmployee()
        {
            InitializeComponent();

            SearchEmployee searchEmployee = new SearchEmployee(SadlData.ViewOrEdit.View);
            this.AddChild(searchEmployee);


        }

       
    }
}
