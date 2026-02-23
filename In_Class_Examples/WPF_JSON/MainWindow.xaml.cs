using Newtonsoft.Json;
using System.IO;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WPF_JSON
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        List<Customer> customers = new List<Customer>();
        public MainWindow()
        {
            InitializeComponent();

            string fileContents = File.ReadAllText("MOCK_DATA.json");

            customers = JsonConvert.DeserializeObject<List<Customer>>(fileContents);

            lstCustomers.ItemsSource = customers;
        }

        private void btnSave_Click(object sender, RoutedEventArgs e)
        {
            Customer selected = lstCustomers.SelectedItem as Customer;
            wndCustomerInfo ci = new wndCustomerInfo();

            ci.LoadCustomerInfo(selected);

            ci.ShowDialog();

        }
    }
}