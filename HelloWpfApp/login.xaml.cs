using System.Windows;

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

        private void btnLogin(object sender, RoutedEventArgs e)
        {
            if (txtUserName.Text == "admin" && txtPassword.Password == "123456")
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
