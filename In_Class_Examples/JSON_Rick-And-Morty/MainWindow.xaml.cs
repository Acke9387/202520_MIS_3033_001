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

namespace JSON_Rick_And_Morty
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            string url = "https://rickandmortyapi.com/api/character";
            RickAndMortyAPI api;

            using (var client = new HttpClient())
            {
                var response = client.GetAsync(url).Result;
                //string json = client.GetStringAsync(url).Result;
                if (response.IsSuccessStatusCode)
                {
                    var json = response.Content.ReadAsStringAsync().Result;
                    api = JsonConvert.DeserializeObject<RickAndMortyAPI>(json);
                    foreach (var character in api.results)
                    {
                        cboCharacters.Items.Add(character);
                    }
                }
            }
        }

        private void cboCharacters_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            CharacterInfo selectedCharater = (CharacterInfo)cboCharacters.SelectedItem;

            if (selectedCharater != null)
            {
                lblName.Content = selectedCharater.name;
                imgCharacter.Source = new BitmapImage(new Uri(selectedCharater.image));
                
                //update the tblink with the url from selectedCharacter
                tbLink.Text = selectedCharater.url;

            }
        }
    }
}