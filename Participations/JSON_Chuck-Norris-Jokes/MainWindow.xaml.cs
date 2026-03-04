using Newtonsoft.Json;
using System.Net.Http;
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

namespace JSON_Chuck_Norris_Jokes
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            string url = "https://api.chucknorris.io/jokes/categories";
            cboCategories.Items.Add("All Categories");

            using(HttpClient client = new HttpClient())
            {
                string json = client.GetStringAsync(url).Result;
                List<string> categories = JsonConvert.DeserializeObject<List<string>>(json);
                foreach (string category in categories)
                {
                    cboCategories.Items.Add(category);
                }
            }
            cboCategories.SelectedIndex = 0;
        }
    }
}