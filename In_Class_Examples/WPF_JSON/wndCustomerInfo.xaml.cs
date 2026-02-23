using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace WPF_JSON
{
    /// <summary>
    /// Interaction logic for wndCustomerInfo.xaml
    /// </summary>
    public partial class wndCustomerInfo : Window
    {
        public Customer Customer { get; set; }
        public wndCustomerInfo()
        {
            InitializeComponent();
        }

        public void LoadCustomerInfo(Customer c)
        {
            this.Customer = c;
            txtFirstName.Text = c.first_name;
            txtLastname.Text = c.last_name;
        }

    }
}
