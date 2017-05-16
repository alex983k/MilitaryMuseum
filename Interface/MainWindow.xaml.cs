using System.Windows;

namespace Interface
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            //MessageBox.Show("Muie");
            Login page = new Login();
            this.Close();
            page.Show();

        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            Login page = new Login();
            this.Close();
            page.Show();
        }
    }
}
