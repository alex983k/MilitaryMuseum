using Database;
using Login;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes; 

namespace Interface
{
    /// <summary>
    /// Interaction logic for Login.xaml
    /// </summary>
    public partial class Login : Window
    {

        private LoginValidation logInvalidator = new LoginValidation(); 
        public Login()
        {
            //InitializeComponent();
           // DataContext = new item
        }

        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            DataContext.Equals("admin");
            
        }

        private void TextBox_TextChanged_1(object sender, TextChangedEventArgs e)
        {
            
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            string a = "rtry";

            if(logInvalidator.Login(UsernameTextBox.Text, PasswordTextBox.Text)) MessageBox.Show("Logged in");

        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            MainWindow s = new MainWindow();
            this.Close();
            s.Show();
        }
    }
}
