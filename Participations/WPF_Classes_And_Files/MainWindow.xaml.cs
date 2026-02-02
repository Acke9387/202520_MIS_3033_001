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

namespace WPF_Classes_And_Files
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private List<Toy> toys = new List<Toy>();
        public MainWindow()
        {
            InitializeComponent();
            string[] linesOfFile = File.ReadAllLines("Toys.csv");

            foreach (string line in linesOfFile)
            {
                //line = Manufacturer,Name,Price,Image
                string[] partsOfLine = line.Split(',');
                Toy myToy = new Toy();
                myToy.Manufacturer = partsOfLine[0];
                myToy.Name = partsOfLine[1];
                myToy.Price = double.Parse(partsOfLine[2]);
                myToy.Image = partsOfLine[3];
                //partsOfLine[0] = Manufacturer
                //partsOfLine[1] = Name
                //partsOfLine[2] = Price
                //partsOfLine[3] = Image
                toys.Add(myToy);
            }

        }
    }
}