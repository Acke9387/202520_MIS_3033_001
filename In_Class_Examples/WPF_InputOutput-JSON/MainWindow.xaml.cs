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

namespace WPF_InputOutput_JSON
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private List<Snack> snacks = new List<Snack>();
        public MainWindow()
        {
            InitializeComponent();
            string fileContent = File.ReadAllText("Superbowl_Snacks.json");
            snacks = JsonConvert.DeserializeObject<List<Snack>>(fileContent);

            cboSpicyLevel.Items.Add("All levels");
            foreach (Snack item in snacks)
            {
                if (cboSpicyLevel.Items.Contains(item.spiciness_level) == false)
                {
                    cboSpicyLevel.Items.Add(item.spiciness_level);
                }

                lstSnacks.Items.Add(item);
            }

        }

        private void cboSpicyLevel_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            string spice_level = cboSpicyLevel.SelectedItem.ToString();

            lstSnacks.Items.Clear();

            foreach (Snack item in snacks)
            {
                if (item.spiciness_level == spice_level ||
                    spice_level == "All levels")
                {
                    lstSnacks.Items.Add(item);
                }
            }
        }

        private void btnSave_Click(object sender, RoutedEventArgs e)
        {
            string fileName = $"{cboSpicyLevel.SelectedItem.ToString()}_data.json";

            string fileContentsAsJson = JsonConvert.SerializeObject(lstSnacks.Items, Formatting.Indented);

            File.WriteAllText(fileName, fileContentsAsJson);
            MessageBox.Show($"Successfully saved your file: {fileName}");
        }
    }
}