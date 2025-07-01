using System.Windows;
using MyStoreWpfApp_EntityFrameWork.Models;

namespace MyStoreWpfApp_EntityFrameWork
{
    /// <summary>
    /// Interaction logic for LoginWindow.xaml
    /// </summary>
    public partial class LoginWindow : Window
    {
        public LoginWindow()
        {
            InitializeComponent();
        }

        private void btnDangNhap_Click(object sender, RoutedEventArgs e)
        {
            MyStoreContext context = new MyStoreContext();
            AccountMember am = context.AccountMembers
                                .FirstOrDefault(x => x.EmailAddress == txtUserName.Text
                                && x.MemberPassword == txtPassword.Password);
            if (am != null)
            {
                if (am.MemberRole == 1)
                {
                    MessageBox.Show("Đăng nhập thành công - Administrator");
                    AdminWindow aw = new AdminWindow();
                    aw.Show();
                    Close();
                }
                else if (am.MemberRole == 2)
                {
                    MessageBox.Show("Đăng nhập thành công - Nhân viên");
                }
                else
                {
                    MessageBox.Show("Đăng nhập thành công - tài khoản khác");
                }
            }
            else
            {
                MessageBox.Show("Đăng nhập thất bại");
            }
        }
    }
}