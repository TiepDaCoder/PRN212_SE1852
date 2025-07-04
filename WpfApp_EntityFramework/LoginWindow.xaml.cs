using System.Windows;

namespace WpfApp_EntityFramework
{
    /// <summary>
    /// Interaction logic for LoginWindow.xaml
    /// </summary>
    public partial class LoginWindow : Window
    {
        IAccountMemberService accountMemberService;
        public LoginWindow()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, RoutedEventArgs e)
        {
            accountMemberService = new AccountMemberService();
            AccountMember ac = accountMemberService.Login(txtEmail.Text,
                                                           txtPassword.Password);
            if (ac == null)
            {
                MessageBox.Show(
                    "Đăng nhập thất bại - vui lòng kiểm tra lại tài khoản",
                    "Đăng nhập thất bại",
                    MessageBoxButton.OK,
                    MessageBoxImage.Error);
                return;
            }
            else if (ac.MemberRole == 1)
            {
                AdminWindow aw = new AdminWindow();
                aw.Show();
                Close();
            }
        }
    }
}