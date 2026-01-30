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

namespace WPF_First_Application
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            txtLastName.Text = "";
            txtFirstName.Focus();
        }

        //private void Button_MouseEnter(object sender, MouseEventArgs e)
        //{
        //    MessageBox.Show("Mouse Entered the Button Area","my caption", MessageBoxButton.AbortRetryIgnore);
        //}

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            string firstName = txtFirstName.Text;
            string lastName = txtLastName.Text;

            MessageBox.Show($"Hello {firstName} {lastName}","Greeting", MessageBoxButton.OK);

            txtLastName.Clear();
            txtFirstName.Text = string.Empty;
        }
    }
}