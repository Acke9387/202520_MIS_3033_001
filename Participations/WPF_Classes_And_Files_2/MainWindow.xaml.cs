using Newtonsoft.Json;
using System.IO;
using System.Text;
using System.Text.Json.Serialization;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WPF_Classes_And_Files_2
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private List<Sale> sales = new List<Sale>();
        public MainWindow()
        {
            InitializeComponent();

            cboPaymentType.Items.Add("All Payment Types");
            string[] linesOfFile = File.ReadAllLines("SalesJan2009.csv");

            foreach (string line in linesOfFile.Skip(1))
            {
                //      0             1       2       3         4    5    6       7       8               9        10        11
                //Transaction_date,Product,Price,Payment_Type,Name,City,State,Country,Account_Created,Last_Login,Latitude,Longitude

                string[] partsOfFile = line.Split(',');
                Sale s = new Sale();
                s.TransactionDate = DateTime.Parse(partsOfFile[0]);
                s.Price = double.Parse(partsOfFile[2].Replace("\"", ""));
                s.PaymentType = partsOfFile[3];
                s.Name = partsOfFile[4];
                s.Country = partsOfFile[7];

                sales.Add(s);
            }

            foreach (Sale s in sales)
            {
                if (cboPaymentType.Items.Contains(s.PaymentType) == false)
                {
                    cboPaymentType.Items.Add(s.PaymentType);
                }
                lstSales.Items.Add(s);
            }

        }

        private void cboPaymentType_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            string selectedPaymentType = cboPaymentType.SelectedItem as string;

            lstSales.Items.Clear();
            foreach (Sale s in sales)
            {
                if (selectedPaymentType == "All Payment Types" || s.PaymentType == selectedPaymentType)
                {
                    lstSales.Items.Add(s);
                }
            }
        }

        private void btnSave_Click(object sender, RoutedEventArgs e)
        {
            string filePath = "FilteredSales.json";
            string json = JsonConvert.SerializeObject(lstSales.Items);

            File.WriteAllText(filePath, json, Encoding.UTF8);

            MessageBox.Show($"Filtered sales saved to {filePath}");
        }
    }
}