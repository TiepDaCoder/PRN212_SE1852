using System.Windows;
using System.Windows.Controls;

namespace HelloWpfApp
{
    /// <summary>
    /// Interaction logic for login.xaml
    /// </summary>
    public partial class login : Window
    {
        public login()
        {
            InitializeComponent();
        }

        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void btnLogin(object sender, RoutedEventArgs e)
        {
            if (txtUserName.Text == "obama" && txtPassword.Text == "123")
            {
                MainWindow mw = new MainWindow();
                mw.Show();
                Close();
            }
            else
            {
                MessageBox.Show("Đăng nhập thất bại!");
            }
        }

        private void btnExit(object sender, RoutedEventArgs e)
        {
            Close();
        }
    }
}
